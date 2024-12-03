using Code.Constants;
using Code.Gameplay.Syringe;
using Code.Gameplay.UI.MainMenu.Skins;
using Code.Gameplay.UI.NewSkin;
using Code.Services.Factories;
using Code.Services.Providers;
using Code.StaticData.Skins;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.ResourceProviders;
using UnityEngine.SceneManagement;

namespace Code.Services
{
  public class NewSkinSceneService
  {
    private readonly CameraProvider _cameraProvider;
    private readonly SceneLoader _sceneLoader;
    private readonly ParentsProvider _parentsProvider;
    private readonly SyringeFactory _syringeFactory;
    private readonly InputService _inputService;
    private readonly StaticDataService _staticData;

    private Transform _newSkinStandTransform;
    private Vector3 _skinRotationPoint;
    private NewSkinHud _newSkinHud;
    private AudioSource _audioSource;

    private SceneInstance _sceneInstance;

    public NewSkinSceneService(SceneLoader sceneLoader, CameraProvider cameraProvider, ParentsProvider parentsProvider,
      SyringeFactory syringeFactory, InputService inputService, StaticDataService staticDataService)
    {
      _sceneLoader = sceneLoader;
      _parentsProvider = parentsProvider;
      _syringeFactory = syringeFactory;
      _inputService = inputService;
      _staticData = staticDataService;
      _cameraProvider = cameraProvider;
    }

    private NewSkinSceneConfig NewSkinSceneConfig => _staticData.ForSkins.NewSkinSceneConfig;

    public void Initialize(Transform newSkinStandTransform, Vector3 skinRotationPoint, NewSkinHud newSkinHud, AudioSource audioSource)
    {
      _audioSource = audioSource;
      _newSkinHud = newSkinHud;
      _skinRotationPoint = skinRotationPoint;
      _newSkinStandTransform = newSkinStandTransform;
    }

    public async UniTask ShowSkinScene(SkinType skinType)
    {
      await LoadSceneAndDisableMainSceneRenderers();

      _audioSource.PlayOneShot(NewSkinSceneConfig.NewSkinSound);
      UniTask hudInitTask = _newSkinHud.InitializeAsync(skinType);
      SyringeMesh syringeMesh = await _syringeFactory.CreateMesh(skinType, _newSkinStandTransform);
      syringeMesh.transform.localScale = Vector3.one;
      SyringeRotation syringeRotation = syringeMesh.gameObject.AddComponent<SyringeRotation>();
      syringeRotation.Construct(_inputService, _staticData);
      syringeRotation.Initialize(_skinRotationPoint);
      await hudInitTask;
      await _newSkinHud.CloseSkinButtonClick;
      await HideSkinScene();
    }

    private async UniTask LoadSceneAndDisableMainSceneRenderers()
    {
      UniTask<SceneInstance> loadSceneTask = _sceneLoader.LoadAsync(SceneName.NewSkin, LoadSceneMode.Additive);
      _sceneLoader.MainSceneRenderersSetActive(false);
      _sceneInstance = await loadSceneTask;
    }

    private async UniTask HideSkinScene()
    {
      await Addressables.UnloadSceneAsync(_sceneInstance);
      _sceneLoader.MainSceneRenderersSetActive(true);
    }
  }
}