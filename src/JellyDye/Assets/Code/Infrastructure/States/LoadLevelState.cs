using System;
using Code.Constants;
using Code.Enums;
using Code.Infrastructure.States.Interfaces;
using Code.Services;
using Code.Services.LevelLoad;
using Code.Services.Progress;
using Code.Services.Progress.SaveLoad;
using Cysharp.Threading.Tasks;

namespace Code.Infrastructure.States
{
  public class LoadLevelState : IPayloadState<string>
  {
    private readonly GameStateMachine _gameStateMachine;
    private readonly ProgressService _progress;
    private readonly StaticDataService _staticData;
    private readonly AnalyticsService _analyticsService;
    private readonly SceneLoader _sceneLoader;

    private readonly LevelInitializationService _levelInitializationService;
    private readonly LevelRestartService _levelRestartService;
    private readonly LevelChangeService _levelChangeService;
    private readonly AssetsWaitService _assetsWaitService;
    private readonly ISaveLoadService _saveLoadService;
    private readonly PublishService _publishService;

    private string _currentLevelId;
    private bool _isFirstLoad = true;

    public LoadLevelState(GameStateMachine gameStateMachine, ProgressService progress, StaticDataService staticData,
      AnalyticsService analyticsService, SceneLoader sceneLoader, LevelInitializationService levelInitializationService,
      LevelRestartService levelRestartService, LevelChangeService levelChangeService, AssetsWaitService assetsWaitService,
      ISaveLoadService saveLoadService, PublishService publishService)
    {
      _gameStateMachine = gameStateMachine;
      _progress = progress;
      _staticData = staticData;
      _analyticsService = analyticsService;
      _sceneLoader = sceneLoader;
      _levelInitializationService = levelInitializationService;
      _levelRestartService = levelRestartService;
      _levelChangeService = levelChangeService;
      _assetsWaitService = assetsWaitService;
      _saveLoadService = saveLoadService;
      _publishService = publishService;
    }

    public async UniTaskVoid Enter(string levelId)
    {
      _currentLevelId = levelId;
      LevelLoadingType loadingType = GetLevelLoadingType();

      switch (loadingType)
      {
        case LevelLoadingType.Initialization:
          await _assetsWaitService.WaitFirstLevelAssetsAsync();
          await _sceneLoader.LoadAsync(SceneName.Main);
          await _levelInitializationService.SetupLevel(levelId);
          _publishService.GameReadyToPlay();
          break;

        case LevelLoadingType.Restart:
          await _levelRestartService.RestartCurrentLevel();
          break;

        case LevelLoadingType.ChangeLevel:
          _progress.ForLevels.CurrentLevelId = levelId;
          _saveLoadService.SaveProgress();
          await _assetsWaitService.WaitChangedLevelAssetsAsync();
          await _levelChangeService.ChangeLevel(levelId);
          break;

        default:
          throw new ArgumentOutOfRangeException();
      }

      switch (loadingType)
      {
        case LevelLoadingType.Initialization:
        case LevelLoadingType.ChangeLevel:
          await _assetsWaitService.InitializeConfigMeshes();
          break;
      }

      _gameStateMachine.Enter<GameLoopState>();
      if (_staticData.ForDevelopHelpers.FinishLevelImmediately)
        _gameStateMachine.Enter<FinishLevelState>();
    }

    public UniTaskVoid Exit()
    {
      if (_isFirstLoad)
        _isFirstLoad = false;

      int levelIndex = _staticData.ForLevels.GetLevelIndex(_currentLevelId);
      _analyticsService.LevelStart(levelIndex, _currentLevelId);
      return default;
    }

    private LevelLoadingType GetLevelLoadingType()
    {
      LevelLoadingType loadingType;
      if (_isFirstLoad)
        loadingType = LevelLoadingType.Initialization;
      else if (_currentLevelId == _progress.ForLevels.CurrentLevelId)
        loadingType = LevelLoadingType.Restart;
      else
        loadingType = LevelLoadingType.ChangeLevel;

      return loadingType;
    }
  }
}