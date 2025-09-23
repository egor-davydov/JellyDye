using System.Threading.Tasks;
using Code.Constants;
using Code.Enums;
using Code.Gameplay.Syringe;
using Code.Services.Factories;
using Code.Services.Providers;
using Code.StaticData.Skins;
using Code.UI.SkinShow;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.ResourceProviders;
using UnityEngine.SceneManagement;

namespace Code.Services
{
  public class SkinShowSceneService
  {
    private readonly CameraProvider _cameraProvider;
    private readonly SceneLoader _sceneLoader;
    private readonly ParentsProvider _parentsProvider;
    private readonly SyringeFactory _syringeFactory;
    private readonly InputService _inputService;
    private readonly StaticDataService _staticData;

    private Transform _newSkinStandTransform;
    private Vector3 _skinRotationPoint;
    private SkinShowHud _skinShowHud;
    private AudioSource _audioSource;

    private SceneInstance _sceneInstance;

    public SkinShowSceneService(SceneLoader sceneLoader, CameraProvider cameraProvider, ParentsProvider parentsProvider,
      SyringeFactory syringeFactory, InputService inputService, StaticDataService staticDataService)
    {
      _sceneLoader = sceneLoader;
      _parentsProvider = parentsProvider;
      _syringeFactory = syringeFactory;
      _inputService = inputService;
      _staticData = staticDataService;
      _cameraProvider = cameraProvider;
    }

    private SkinShowSceneConfig SkinShowSceneConfig => _staticData.ForSkins.SkinShowSceneConfig;

    public void Initialize(Transform newSkinStandTransform, Vector3 skinRotationPoint, SkinShowHud skinShowHud, AudioSource audioSource)
    {
      _audioSource = audioSource;
      _skinShowHud = skinShowHud;
      _skinRotationPoint = skinRotationPoint;
      _newSkinStandTransform = newSkinStandTransform;
    }

    public async UniTask ShowSkinScene(SkinType skinType)
    {
      await LoadSceneAndDisableMainSceneRenderers();

      _audioSource.PlayOneShot(SkinShowSceneConfig.NewSkinSound);
      UniTask hudInitTask = _skinShowHud.InitializeAsync(skinType);
      await CreateAndInitSyringe(skinType);
      await hudInitTask;
      await _skinShowHud.CloseSkinButtonClick;
      await NewSkinSceneUnloadAndLoadMain();
    }

    private async UniTask CreateAndInitSyringe(SkinType skinType)
    {
      SyringeMesh syringeMesh = await _syringeFactory.CreateMesh(skinType, _newSkinStandTransform);
      syringeMesh.transform.localScale = Vector3.one;
      SyringeRotation syringeRotation = syringeMesh.gameObject.AddComponent<SyringeRotation>();
      syringeRotation.Construct(_inputService, _staticData);
      syringeRotation.Initialize(_skinRotationPoint);
    }

    private async UniTask LoadSceneAndDisableMainSceneRenderers()
    {
      UniTask<SceneInstance> loadSceneTask = _sceneLoader.LoadAsync(SceneName.NewSkin, LoadSceneMode.Additive);
      _sceneLoader.MainSceneRenderersSetActive(false);
      _sceneInstance = await loadSceneTask;
    }

    private async UniTask NewSkinSceneUnloadAndLoadMain()
    {
      await Addressables.UnloadSceneAsync(_sceneInstance);
      _sceneLoader.MainSceneRenderersSetActive(true);
    }
  }
}