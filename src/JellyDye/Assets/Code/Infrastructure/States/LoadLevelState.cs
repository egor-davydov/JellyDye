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
using Code.StaticData;
using Fluxy;
using UnityEngine;

namespace Code.Infrastructure.States
{
  public class LoadLevelState : IPayloadState<string>
  {
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

    private string _levelId;
    private int _levelIndex;
    private LevelData _progressLevelData;

    public LoadLevelState(GameStateMachine gameStateMachine, SceneLoader sceneLoader,
      HudFactory hudFactory, SyringeFactory syringeFactory, JelliesFactory jelliesFactory,
      ProgressService progressService, StaticDataService staticDataService,
      PaintCountCalculationService paintCountCalculationService, FinishLevelService finishLevelService,
      ISaveLoadService saveLoadService, AnalyticsService analyticsService)
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
      
    }

    public void Enter(string levelId)
    {
      _progressLevelData ??= _progressService.Progress.LevelData;
      _levelId = levelId;
      _progressLevelData.CurrentLevelId = _levelId;
      //Debug.Log($"Enter LoadLevelState LoadingSceneIndex: '{levelId}'");
      _sceneLoader.StartLoad(1, OnLoadComplete);
    }

    public void Exit()
    {
      _analyticsService.LevelStart(_levelIndex, _levelId);
    }

    private void OnLoadComplete()
    {
      _levelIndex = _staticDataService.ForLevels().GetLevelIndex(_progressLevelData.CurrentLevelId);
      _saveLoadService.SaveProgress();
      LevelConfig levelConfig = _staticDataService.ForLevels().GetConfigByLevelId(_levelId);

      GameObject jelliesObject = InitJellies(levelConfig);
      FluxySolver fluxySolver = jelliesObject.GetComponentInChildren<FluxySolver>();
      _paintCountCalculationService.InitializeOnSceneLoad(fluxySolver, jelliesObject.GetComponentsInChildren<FluxyContainer>());

      GameObject syringeObject = InitSyringe();

      GameObject hudObject = InitHud(syringeObject, levelConfig);
      
      SyringeInjection syringeInjection = syringeObject.GetComponent<SyringeInjection>();
      syringeInjection.Initialize(hudObject.GetComponentInChildren<InjectionButton>());
      _finishLevelService.Initialize(hudObject, syringeObject);

      _gameStateMachine.Enter<GameLoopState>();
    }

    private GameObject InitJellies(LevelConfig levelConfig)
    {
      GameObject jelliesObject = _jelliesFactory.CreateJelly(levelConfig.JelliesPrefab);
      return jelliesObject;
    }

    private GameObject InitSyringe()
    {
      SkinType equippedSkin = _progressService.Progress.SkinData.EquippedSkin;
      GameObject syringeObject = _syringeFactory.CreateSyringe(equippedSkin, Vector3.up * 0.14f);
      syringeObject.GetComponent<SyringeInjection>().SyringeReset();
      return syringeObject;
    }

    private GameObject InitHud(GameObject syringeObject, LevelConfig levelConfig)
    {
      SyringePaint syringePaint = syringeObject.GetComponent<SyringePaint>();
      GameObject hudObject = _hudFactory.CreateHud();
      hudObject.GetComponentInChildren<ColorChangersContainer>().Initialize(syringePaint, levelConfig.Colors);
      hudObject.GetComponentInChildren<ScreenshotTargetColors>().Initialize(levelConfig.TargetTexture, _levelIndex + 1);
      return hudObject;
    }
  }
}