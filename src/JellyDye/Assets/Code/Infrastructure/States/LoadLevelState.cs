using Code.Gameplay.Hud;
using Code.Gameplay.Hud.PaintChange;
using Code.Gameplay.Logic;
using Code.Gameplay.Syringe;
using Code.Gameplay.UI.MainMenu.Skins;
using Code.Services;
using Code.Services.Factories;
using Code.Services.Progress;
using Code.StaticData;
using Fluxy;
using UnityEngine;

namespace Code.Infrastructure.States
{
  public class LoadLevelState : IPayloadState<int>
  {
    private readonly GameStateMachine _gameStateMachine;
    private readonly SceneLoader _sceneLoader;
    private readonly LoadingCurtain _loadingCurtain;
    private readonly HudFactory _hudFactory;
    private readonly SyringeFactory _syringeFactory;
    private readonly JelliesFactory _jelliesFactory;
    private readonly ProgressService _progressService;
    private readonly StaticDataService _staticDataService;
    private readonly PaintCountCalculationService _paintCountCalculationService;
    private readonly LevelFinishService _levelFinishService;
    private int _levelIndex;

    public LoadLevelState(GameStateMachine gameStateMachine, SceneLoader sceneLoader, LoadingCurtain loadingCurtain,
      HudFactory hudFactory, SyringeFactory syringeFactory, JelliesFactory jelliesFactory, ProgressService progressService,
      StaticDataService staticDataService, PaintCountCalculationService paintCountCalculationService, LevelFinishService levelFinishService)
    {
      _gameStateMachine = gameStateMachine;
      _sceneLoader = sceneLoader;
      _loadingCurtain = loadingCurtain;
      _hudFactory = hudFactory;
      _syringeFactory = syringeFactory;
      _jelliesFactory = jelliesFactory;
      _progressService = progressService;
      _staticDataService = staticDataService;
      _paintCountCalculationService = paintCountCalculationService;
      _levelFinishService = levelFinishService;
    }

    public void Enter(int levelIndex)
    {
      _levelIndex = levelIndex;
      //Debug.Log($"Enter LoadLevelState LoadingSceneIndex: '{levelIndex}'");
      _sceneLoader.StartLoad(1, OnLoadComplete);
    }

    public void Exit()
    {
    }

    private void OnLoadComplete()
    {
      _progressService.Progress.CurrentLevel = _levelIndex;
      LevelConfig levelConfig = _staticDataService.ForLevels().LevelConfigs[_levelIndex];
      
      GameObject jelliesObject = InitJellies(levelConfig);
      _paintCountCalculationService.Initialize(jelliesObject.GetComponentInChildren<FluxySolver>(), jelliesObject.GetComponentsInChildren<FluxyContainer>());
      
      GameObject syringeObject = InitSyringe();
      
      GameObject hudObject = InitHud(syringeObject, levelConfig);
      PaintInjection paintInjection = syringeObject.GetComponent<PaintInjection>();
      paintInjection.Initialize(hudObject.GetComponentInChildren<InjectionButton>());
      _levelFinishService.Initialize(paintInjection, hudObject, syringeObject);
      
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
      syringeObject.GetComponent<PaintInjection>().SyringeReset();
      return syringeObject;
    }

    private GameObject InitHud(GameObject syringeObject, LevelConfig levelConfig)
    {
      SyringePaint syringePaint = syringeObject.GetComponent<SyringePaint>();
      GameObject hudObject = _hudFactory.CreateHud();
      hudObject.GetComponentInChildren<ColorChangersContainer>().Initialize(syringePaint, levelConfig.Colors);
      return hudObject;
    }
  }
}