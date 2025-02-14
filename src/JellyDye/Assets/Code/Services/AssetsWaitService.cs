using System.Collections.Generic;
using System.Linq;
using Code.Constants;
using Code.Services.AssetManagement;
using Code.Services.Progress;
using Code.Services.Providers;
using Code.StaticData;
using Code.StaticData.Level;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceProviders;
using UnityEngine.SceneManagement;

namespace Code.Services
{
  public class AssetsWaitService
  {
    private const int InitializationNecessaryAssetsCount = 4;

    private readonly IAssetProvider _assetProvider;
    private readonly StaticDataService _staticData;
    private readonly SceneLoader _sceneLoader;
    private readonly ProgressService _progress;
    private readonly LevelLoadingFillProvider _levelLoadingFillProvider;

    public AssetsWaitService(IAssetProvider assetProvider, StaticDataService staticData, SceneLoader sceneLoader,
      LevelLoadingFillProvider levelLoadingFillProvider, ProgressService progress)
    {
      _assetProvider = assetProvider;
      _staticData = staticData;
      _sceneLoader = sceneLoader;
      _progress = progress;
      _levelLoadingFillProvider = levelLoadingFillProvider;
    }

    private bool IsSimulateLoadingTime => _staticData.ForDevelopHelpers.SimulateLoadingTime > 0;
    private LevelConfig CurrentLevelConfig => _staticData.ForLevel(_progress.ForLevels.CurrentLevelId);
    private int LevelNecessaryAssetsCount => 2 + CurrentLevelConfig.JellyMeshConfigs.Count; // 2 - JellyPrefab and SyringeSkin

    public async UniTask WaitFirstLevelAssetsAsync()
    {
      List<AsyncOperationHandle> operations = GetFirstLevelOperations();
      if (!IsNeedLoad(operations))
        return;

      await _sceneLoader.LoadAsync(SceneName.Load);
      await WaitOperations(operations);
    }

    public async UniTask WaitChangedLevelAssetsAsync()
    {
      List<AsyncOperationHandle> operations = GetLevelChangeOperations();
      if (!IsNeedLoad(operations))
        return;

      SceneInstance loadScene = await _sceneLoader.LoadAsync(SceneName.Load, LoadSceneMode.Additive);
      _sceneLoader.MainSceneRenderersSetActive(false);
      await WaitOperations(operations);
      await _sceneLoader.UnloadAsync(loadScene);
      _sceneLoader.MainSceneRenderersSetActive(true);
    }

    public async UniTask InitializeConfigMeshes()
    {
      foreach (JellyMeshConfig jellyMeshConfig in CurrentLevelConfig.JellyMeshConfigs)
        jellyMeshConfig.Mesh = await _assetProvider.Load<Mesh>(jellyMeshConfig.MeshReference);
    }

    private bool IsNeedLoad(List<AsyncOperationHandle> operations) =>
      !operations.All(x => x.IsDone) || IsSimulateLoadingTime;

    private async UniTask WaitOperations(List<AsyncOperationHandle> operations)
    {
      _levelLoadingFillProvider.LevelLoadingFill.StartFill(operations).Forget();
      await UniTask.WaitUntil(() => operations.All(x => x.IsDone));
      if (IsSimulateLoadingTime)
        await UniTask.WaitForSeconds(_staticData.ForDevelopHelpers.SimulateLoadingTime);
    }

    private List<AsyncOperationHandle> GetFirstLevelOperations()
    {
      List<AsyncOperationHandle> operations = new(InitializationNecessaryAssetsCount + LevelNecessaryAssetsCount);
      AddNecessaryLevelAssets(operations);

      operations.Add(_assetProvider.WarmUpAsset<GameObject>(AssetKey.Jar));
      operations.Add(_assetProvider.WarmUpAsset<GameObject>(AssetKey.Hud));
      operations.Add(_assetProvider.WarmUpAsset<GameObject>(AssetKey.MainMenu));
      operations.Add(_assetProvider.WarmUpAsset<GameObject>(AssetKey.FinishWindow));
      return operations;
    }

    private List<AsyncOperationHandle> GetLevelChangeOperations()
    {
      List<AsyncOperationHandle> operations = new(LevelNecessaryAssetsCount);
      AddNecessaryLevelAssets(operations);

      return operations;
    }

    private void AddNecessaryLevelAssets(List<AsyncOperationHandle> handles)
    {
      handles.Add(_assetProvider.WarmUpAsset<GameObject>(CurrentLevelConfig.JelliesPrefabReference));
      foreach (JellyMeshConfig jellyMeshConfig in CurrentLevelConfig.JellyMeshConfigs)
        handles.Add(_assetProvider.WarmUpAsset<Mesh>(jellyMeshConfig.MeshReference));

      AssetReference syringeSkinReference = _staticData.ForSkin(_progress.ForSkins.EquippedSkin).SkinReference;
      handles.Add(_assetProvider.WarmUpAsset<GameObject>(syringeSkinReference));
    }
  }
}