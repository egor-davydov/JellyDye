using Code.Data;
using Code.Gameplay.Syringe;
using Code.Gameplay.UI.Hud;
using Code.Gameplay.UI.Hud.PaintChange;
using Code.Gameplay.UI.MainMenu.Skins;
using Code.Services;
using Code.Services.Factories;
using Code.Services.Factories.UI;
using Code.Services.Progress;
using Code.Services.Progress.SaveLoad;
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
    private readonly ProgressService _progressService;
    private readonly StaticDataService _staticDataService;
    private readonly PaintCountCalculationService _paintCountCalculationService;
    private readonly FinishLevelService _finishLevelService;
    private readonly ISaveLoadService _saveLoadService;
    private readonly AnalyticsService _analyticsService;
    private readonly PublishService _publishService;

    private string _levelId;
    private int _levelIndex;
    private bool _isFirstLoad = true;
    private LevelsStaticData _levelsStaticData;

    public LoadLevelState(GameStateMachine gameStateMachine, SceneLoader sceneLoader,
      HudFactory hudFactory, SyringeFactory syringeFactory, JelliesFactory jelliesFactory,
      ProgressService progressService, StaticDataService staticDataService,
      PaintCountCalculationService paintCountCalculationService, FinishLevelService finishLevelService,
      ISaveLoadService saveLoadService, AnalyticsService analyticsService, PublishService publishService)
    {
      _gameStateMachine = gameStateMachine;
      _sceneLoader = sceneLoader;
      _hudFactory = hudFactory;
      _syringeFactory = syringeFactory;
      _jelliesFactory = jelliesFactory;
      _progressService = progressService;
      _staticDataService = staticDataService;
      _paintCountCalculationService = paintCountCalculationService;
      _finishLevelService = finishLevelService;
      _saveLoadService = saveLoadService;
      _analyticsService = analyticsService;
      _publishService = publishService;
    }

    private LevelData ProgressLevelData => _progressService.Progress.LevelData;

    public void Enter(string levelId)
    {
      _levelId = levelId;
      if(_levelId != ProgressLevelData.CurrentLevelId)
      {
        ProgressLevelData.CurrentLevelId = _levelId;
        _saveLoadService.SaveProgress();
      }
      //Debug.Log($"Enter LoadLevelState LoadingSceneIndex: '{levelId}'");
      _publishService.ShowFullscreenAdvAndPauseGame();
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
      _levelsStaticData ??= _staticDataService.ForLevels();
      _levelIndex = _levelsStaticData.GetLevelIndex(_levelId);
      LevelConfig levelConfig = _levelsStaticData.GetConfigByLevelId(_levelId);

      GameObject jelliesObject = InitJellies(levelConfig);
      FluxySolver fluxySolver = jelliesObject.GetComponentInChildren<FluxySolver>();
      _paintCountCalculationService.InitializeOnSceneLoad(fluxySolver, jelliesObject.GetComponentsInChildren<FluxyContainer>());

      GameObject syringeObject = InitSyringe();

      GameObject hudObject = await InitHud(syringeObject, levelConfig);
      
      SyringeInjection syringeInjection = syringeObject.GetComponent<SyringeInjection>();
      syringeInjection.Initialize(hudObject.GetComponentInChildren<InjectionButton>());
      _finishLevelService.Initialize(hudObject, syringeObject);

      _gameStateMachine.Enter<GameLoopState>();
    }

    private GameObject InitJellies(LevelConfig levelConfig)
    {
      GameObject jelliesObject = _jelliesFactory.CreateJelly(levelConfig.Id);
      return jelliesObject;
    }

    private GameObject InitSyringe()
    {
      SkinType equippedSkin = _progressService.Progress.SkinData.EquippedSkin;
      GameObject syringeObject = _syringeFactory.CreateSyringe(equippedSkin, Vector3.up * 0.14f);
      syringeObject.GetComponent<SyringeInjection>().SyringeReset();
      return syringeObject;
    }

    private async UniTask<GameObject> InitHud(GameObject syringeObject, LevelConfig levelConfig)
    {
      SyringePaintColor syringePaintColor = syringeObject.GetComponent<SyringePaintColor>();
      GameObject hudObject = await _hudFactory.CreateHud();
      hudObject.GetComponentInChildren<ColorChangersContainer>().Initialize(syringePaintColor, levelConfig.AllColorsCached);
      hudObject.GetComponentInChildren<ScreenshotTargetColors>().Initialize(levelConfig.TargetTexture, _levelIndex + 1);
      return hudObject;
    }
  }
}