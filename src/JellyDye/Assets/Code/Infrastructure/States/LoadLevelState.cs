using Code.Data;
using Code.Gameplay.UI.Hud;
using Code.Gameplay.UI.MainMenu.Skins;
using Code.Services;
using Code.Services.AssetManagement;
using Code.Services.Factories;
using Code.Services.Factories.UI;
using Code.Services.Progress;
using Code.Services.Progress.SaveLoad;
using Code.Services.Providers;
using Code.StaticData;
using Code.StaticData.Level;
using Cysharp.Threading.Tasks;
using Fluxy;
using UnityEngine;

namespace Code.Infrastructure.States
{
  public class LoadLevelState : IPayloadState<string>
  {
    private const string MainSceneName = "Main";
    
    private readonly GameStateMachine _gameStateMachine;
    private readonly SceneLoader _sceneLoader;
    private readonly HudFactory _hudFactory;
    private readonly SyringeFactory _syringeFactory;
    private readonly JelliesFactory _jelliesFactory;
    private readonly IAssetProvider _assetProvider;
    private readonly ProgressService _progressService;
    private readonly StaticDataService _staticDataService;
    private readonly PaintCountCalculationService _paintCountCalculationService;
    private readonly FinishLevelService _finishLevelService;
    private readonly ISaveLoadService _saveLoadService;
    private readonly AnalyticsService _analyticsService;
    private readonly PublishService _publishService;
    private readonly SyringeProvider _syringeProvider;
    private readonly HudProvider _hudProvider;

    private string _levelId;
    private int _levelIndex;
    private bool _isFirstLoad = true;
    private LevelsStaticData _levelsStaticData;
    private LevelConfig _levelConfig;

    public LoadLevelState(GameStateMachine gameStateMachine, SceneLoader sceneLoader,
      HudFactory hudFactory, SyringeFactory syringeFactory, JelliesFactory jelliesFactory,
      IAssetProvider assetProvider, ProgressService progressService, StaticDataService staticDataService,
      PaintCountCalculationService paintCountCalculationService, FinishLevelService finishLevelService,
      ISaveLoadService saveLoadService, AnalyticsService analyticsService, PublishService publishService,
      SyringeProvider syringeProvider, HudProvider hudProvider)
    {
      _gameStateMachine = gameStateMachine;
      _sceneLoader = sceneLoader;
      _hudFactory = hudFactory;
      _syringeFactory = syringeFactory;
      _jelliesFactory = jelliesFactory;
      _assetProvider = assetProvider;
      _progressService = progressService;
      _staticDataService = staticDataService;
      _paintCountCalculationService = paintCountCalculationService;
      _finishLevelService = finishLevelService;
      _saveLoadService = saveLoadService;
      _analyticsService = analyticsService;
      _publishService = publishService;
      _syringeProvider = syringeProvider;
      _hudProvider = hudProvider;
    }

    private LevelData ProgressLevelData => _progressService.Progress.LevelData;

    public async void Enter(string levelId)
    {
      _levelId = levelId;
      if(_levelId != ProgressLevelData.CurrentLevelId)
      {
        ProgressLevelData.CurrentLevelId = _levelId;
        _saveLoadService.SaveProgress();
      }

      if (_isFirstLoad)
      {
        _levelsStaticData = _staticDataService.ForLevels();
        await _assetProvider.Load<GameObject>(AssetKey.LevelButton);
      }
      _levelIndex = _levelsStaticData.GetLevelIndex(_levelId);
      _levelConfig = _levelsStaticData.GetConfigByLevelId(_levelId);
      foreach (JellyMeshConfig jellyMeshConfig in _levelConfig.JellyMeshConfigs)
        jellyMeshConfig.Mesh = await _assetProvider.Load<Mesh>(jellyMeshConfig.MeshReference);
      //Debug.Log($"Enter LoadLevelState LoadingSceneIndex: '{levelId}'");
      //_publishService.ShowFullscreenAdvAndPauseGame();
      _sceneLoader.StartLoad(loadId: MainSceneName, OnLoadComplete);
    }

    public void Exit()
    {
      if(_isFirstLoad)
      {
        _publishService.GameReadyToPlay();
        _isFirstLoad = false;
      }
      _analyticsService.LevelStart(_levelIndex, _levelId);
    }

    private async void OnLoadComplete()
    {
      GameObject jelliesObject = await InitJellies(_levelConfig);
      FluxySolver fluxySolver = jelliesObject.GetComponentInChildren<FluxySolver>();
      _paintCountCalculationService.InitializeOnSceneLoad(fluxySolver, jelliesObject.GetComponentsInChildren<FluxyContainer>());

      await InitSyringe();
      
      await InitHud(_levelConfig);
      
      _syringeProvider.SyringeInjection.Initialize(_hudProvider.InjectionButton);
      
      _finishLevelService.Initialize();
      _gameStateMachine.Enter<GameLoopState>();
    }

    private async UniTask<GameObject> InitJellies(LevelConfig levelConfig)
    {
      GameObject jelliesObject = await _jelliesFactory.CreateJelly(levelConfig.Id);
      return jelliesObject;
    }

    private async UniTask InitSyringe()
    {
      SkinType equippedSkin = _progressService.Progress.SkinData.EquippedSkin;
      GameObject syringeObject = await _syringeFactory.CreateSyringe(equippedSkin, Vector3.up * 0.14f);
      _syringeProvider.Initialize(syringeObject);
      _syringeProvider.SyringeInjection.SyringeReset();
    }

    private async UniTask InitHud(LevelConfig levelConfig)
    {
      GameObject hudObject = await _hudFactory.CreateHud();
      _hudProvider.Initialize(hudObject);
      _hudProvider.JarsContainer.Initialize(levelConfig.AllColorsCached);
      hudObject.GetComponentInChildren<ScreenshotTargetColors>().Initialize(levelConfig.TargetTexture, _levelIndex + 1);
    }
  }
}