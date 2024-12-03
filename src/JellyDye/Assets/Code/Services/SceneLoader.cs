using Code.Services.Providers;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceProviders;
using UnityEngine.SceneManagement;

namespace Code.Services
{
  public class SceneLoader
  {
    private readonly ParentsProvider _parentsProvider;
    private readonly AdditiveSceneInterferingObjectsProvider _additiveSceneInterferingObjectsProvider;
    private readonly SyringeProvider _syringeProvider;

    public SceneLoader(AdditiveSceneInterferingObjectsProvider additiveSceneInterferingObjectsProvider,
      SyringeProvider syringeProvider, ParentsProvider parentsProvider)
    {
      _additiveSceneInterferingObjectsProvider = additiveSceneInterferingObjectsProvider;
      _syringeProvider = syringeProvider;
      _parentsProvider = parentsProvider;
    }

    public float LoadProgress { get; private set; }

    public async UniTask<SceneInstance> LoadAsync(string loadId, LoadSceneMode loadMode = LoadSceneMode.Single)
    {
      LoadProgress = 0;
      AsyncOperationHandle<SceneInstance> loadSceneAsync = Addressables.LoadSceneAsync(loadId, loadMode, SceneReleaseMode.ReleaseSceneWhenSceneUnloaded);

      while (!loadSceneAsync.IsDone)
      {
        LoadProgress = loadSceneAsync.PercentComplete;
        await UniTask.NextFrame(PlayerLoopTiming.LastUpdate);
      }

      return await loadSceneAsync;
    }

    public async UniTask UnloadAsync(SceneInstance sceneInstance) =>
      await Addressables.UnloadSceneAsync(sceneInstance);

    public void MainSceneRenderersSetActive(bool isActive)
    {
      _syringeProvider.SyringeMove.enabled = isActive;
      Renderer[] renderers = _parentsProvider.ParentForGameplay.GetComponentsInChildren<Renderer>();
      foreach (Renderer renderer in renderers)
        renderer.enabled = isActive;
      foreach (GameObject interferingObject in _additiveSceneInterferingObjectsProvider.InterferingObjects)
        interferingObject.SetActive(isActive);
    }
  }
}