using System.Collections.Generic;
using System.Linq;
using Code.Constants;
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
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.SceneManagement;

namespace Code.Infrastructure.States
{
  public class LoadLevelState : IPayloadState<string>
  {
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
    private readonly LevelLoadingFillProvider _levelLoadingFillProvider;
    private readonly ParentsProvider _parentsProvider;

    private string _levelId;
    private int _levelIndex;
    private bool _isFirstLoad = true;
    private LevelConfig _levelConfig;

    public LoadLevelState(GameStateMachine gameStateMachine, SceneLoader sceneLoader,
      HudFactory hudFactory, SyringeFactory syringeFactory, JelliesFactory jelliesFactory,
      IAssetProvider assetProvider, ProgressService progressService, StaticDataService staticDataService,
      PaintCountCalculationService paintCountCalculationService, FinishLevelService finishLevelService,
      ISaveLoadService saveLoadService, AnalyticsService analyticsService, PublishService publishService,
      SyringeProvider syringeProvider, HudProvider hudProvider, LevelLoadingFillProvider levelLoadingFillProvider,
      ParentsProvider parentsProvider)
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
      _levelLoadingFillProvider = levelLoadingFillProvider;
      _parentsProvider = parentsProvider;
    }

    private LevelsStaticData LevelsStaticData => _staticDataService.ForLevels();
    private LevelData ProgressLevelData => _progressService.Progress.LevelData;

    public async UniTaskVoid Enter(string levelId)
    {
      _levelId = levelId;
      bool sameLevelAsInProgress = _levelId == ProgressLevelData.CurrentLevelId;
      if (!sameLevelAsInProgress)
      {
        ProgressLevelData.CurrentLevelId = _levelId;
        _saveLoadService.SaveProgress();
      }

      bool isLevelReloaded = sameLevelAsInProgress && !_isFirstLoad;
      if (!isLevelReloaded)
      {
        _levelIndex = LevelsStaticData.GetLevelIndex(_levelId);
        _levelConfig = LevelsStaticData.GetConfigByLevelId(_levelId);

        List<AsyncOperationHandle> loadingOperations = GetLevelLoadOperations();
        if (!loadingOperations.All(x => x.IsDone))
        {
          await SceneManager.LoadSceneAsync(SceneName.Load);
          _levelLoadingFillProvider.LevelLoadingFill.StartFill(loadingOperations).Forget();
          await UniTask.WaitUntil(() => loadingOperations.All(x => x.IsDone));
        }

        foreach (JellyMeshConfig jellyMeshConfig in _levelConfig.JellyMeshConfigs)
          jellyMeshConfig.Mesh = await _assetProvider.Load<Mesh>(jellyMeshConfig.MeshReference);
      }

      //Debug.Log($"Enter LoadLevelState LoadingSceneIndex: '{levelId}'");
      //_publishService.ShowFullscreenAdvAndPauseGame();
      await _sceneLoader.StartLoad(loadId: SceneName.Main);
      SetupLevel().Forget();
    }

    public UniTaskVoid Exit()
    {
      if (_isFirstLoad)
      {
        _publishService.GameReadyToPlay();
        _isFirstLoad = false;
      }

      _analyticsService.LevelStart(_levelIndex, _levelId);
      return default;
    }

    private async UniTaskVoid SetupLevel()
    {
      GameObject jelliesObject = await InitJellies(_levelConfig);
      FluxySolver fluxySolver = jelliesObject.GetComponentInChildren<FluxySolver>();
      _paintCountCalculationService.InitializeOnSceneLoad(fluxySolver,
        jelliesObject.GetComponentsInChildren<FluxyContainer>());

      await InitSyringe();

      await InitHud(_levelConfig);

      _syringeProvider.SyringeInjection.Initialize(_hudProvider.InjectionButton);

      _finishLevelService.Initialize();
      _finishLevelService.FinishLevel();
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
      GameObject syringeObject = await _syringeFactory.CreateSyringe(equippedSkin, _parentsProvider.ParentForGameplay);
      syringeObject.transform.position = Vector3.up * 0.14f;
      _syringeProvider.Initialize(syringeObject);
      _syringeProvider.SyringeInjection.SyringeReset();
    }

    private async UniTask InitHud(LevelConfig levelConfig)
    {
      GameObject hudObject = await _hudFactory.CreateHud();
      _hudProvider.Initialize(hudObject);
      _hudProvider.JarsContainer.InitializeAndCreateJars(levelConfig.AllColorsCached).Forget();
      hudObject.GetComponentInChildren<ScreenshotTargetColors>().Initialize(levelConfig.TargetTexture, _levelIndex + 1);
    }

    private List<AsyncOperationHandle> GetLevelLoadOperations()
    {
      int necessaryAssetsCount = _isFirstLoad ? 3 : 2;
      List<AsyncOperationHandle> handles = new(necessaryAssetsCount + _levelConfig.JellyMeshConfigs.Count)
      {
        _assetProvider.WarmUpAsset<GameObject>(_levelConfig.JelliesPrefabReference)
      };
      foreach (JellyMeshConfig jellyMeshConfig in _levelConfig.JellyMeshConfigs)
        handles.Add(_assetProvider.WarmUpAsset<Mesh>(jellyMeshConfig.MeshReference));

      if (_isFirstLoad)
        handles.Add(_assetProvider.WarmUpAsset<GameObject>(AssetKey.Hud));

      AssetReference syringeSkinReference = _staticDataService.ForSkins()
        .GetSkinByType(_progressService.Progress.SkinData.EquippedSkin).SkinReference;
      handles.Add(_assetProvider.WarmUpAsset<GameObject>(syringeSkinReference));

      return handles;
    }
  }
}