using Code.Constants;
using Code.Gameplay.UI.MainMenu.Skins;
using Code.Gameplay.UI.NewSkin;
using Code.Services.Factories;
using Code.Services.Providers;
using Code.StaticData.Skins;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Code.Services
{
  public class NewSkinSceneService
  {
    private readonly CameraService _cameraService;
    private readonly ParentsProvider _parentsProvider;
    private readonly SyringeFactory _syringeFactory;
    private readonly InputService _inputService;
    private readonly StaticDataService _staticDataService;

    private Transform _newSkinStandTransform;
    private Vector3 _skinRotationPoint;

    private bool _allowSkinRotation;
    private Vector3 _previousMousePosition;
    private Vector2 _currentRotationVelocity;
    private Vector2 _lastRotationVelocity;
    private NewSkinHud _newSkinHud;

    public NewSkinSceneService(CameraService cameraService, ParentsProvider parentsProvider,
      SyringeFactory syringeFactory, InputService inputService, StaticDataService staticDataService)
    {
      _parentsProvider = parentsProvider;
      _syringeFactory = syringeFactory;
      _inputService = inputService;
      _staticDataService = staticDataService;
      _cameraService = cameraService;
    }

    private NewSkinSceneConfig NewSkinSceneConfig => _staticDataService.ForSkins().NewSkinSceneConfig;

    public void Initialize(Transform newSkinStandTransform, Vector3 skinRotationPoint, NewSkinHud newSkinHud)
    {
      _newSkinHud = newSkinHud;
      _skinRotationPoint = skinRotationPoint;
      _newSkinStandTransform = newSkinStandTransform;
    }

    public async UniTask ShowSkinScene(SkinType skinType)
    {
      await LoadSceneAndDisableMainSceneRenderers();
      UniTask hudInitTask = _newSkinHud.InitializeAsync(skinType, NewSkinSceneConfig.DelayBeforeCloseButtonCreation);
      Transform syringeTransform = (await _syringeFactory.CreateMesh(skinType, _newSkinStandTransform)).transform;
      syringeTransform.localScale = Vector3.one;
      StartSkinRotation(syringeTransform).Forget();
      await hudInitTask;
      await _newSkinHud.CloseSkinButtonClick;
    }

    public async UniTask HideSkinScene()
    {
      StopSkinRotation();
      await SceneManager.UnloadSceneAsync(SceneName.NewSkin);
      MainSceneRenderersSetActive(true);
      SceneManager.SetActiveScene(SceneManager.GetSceneByName(SceneName.Main));
    }

    private async UniTaskVoid StartSkinRotation(Transform syringeTransform)
    {
      bool isUserRotateSkin = false;
      bool isSkinAutoRotating = true;
      _allowSkinRotation = true;
      while (_allowSkinRotation)
      {
        if (isSkinAutoRotating)
        {
          syringeTransform.RotateAround(_skinRotationPoint, Vector3.up,
            -NewSkinSceneConfig.AutoRotationSpeed * Time.deltaTime);
        }

        if (_inputService.IsInputButtonPressed)
        {
          isSkinAutoRotating = false;
          isUserRotateSkin = true;
          _previousMousePosition = Input.mousePosition;
        }

        if (_inputService.IsInputButtonReleased)
        {
          isUserRotateSkin = false;
          _lastRotationVelocity = _currentRotationVelocity;
        }

        if (isUserRotateSkin)
        {
          Vector3 mouseDelta = Input.mousePosition - _previousMousePosition;

          float rotationY = -mouseDelta.x * NewSkinSceneConfig.RotationSpeed * Time.deltaTime;
          float rotationX = mouseDelta.y * NewSkinSceneConfig.RotationSpeed * Time.deltaTime;

          _currentRotationVelocity = new Vector2(rotationX, rotationY);

          RotateWithVelocity(syringeTransform, _currentRotationVelocity);

          _previousMousePosition = Input.mousePosition;
        }
        else if (_lastRotationVelocity != Vector2.zero)
        {
          float dampingFactor = 1f - (NewSkinSceneConfig.InertiaDamping * Time.deltaTime);
          _lastRotationVelocity *= dampingFactor;

          if (_lastRotationVelocity.sqrMagnitude < 0.01f)
            _lastRotationVelocity = Vector2.zero;

          RotateWithVelocity(syringeTransform, _lastRotationVelocity);
        }

        await UniTask.Yield(PlayerLoopTiming.Update);
      }
    }

    private void RotateWithVelocity(Transform rotationTransform, Vector2 rotationVelocity)
    {
      rotationTransform.RotateAround(_skinRotationPoint, Vector3.up, rotationVelocity.y);
      rotationTransform.RotateAround(_skinRotationPoint, Vector3.right, rotationVelocity.x);
    }

    private void StopSkinRotation() =>
      _allowSkinRotation = false;

    private async UniTask LoadSceneAndDisableMainSceneRenderers()
    {
      AsyncOperation loadSceneAsync = SceneManager.LoadSceneAsync(SceneName.NewSkin, LoadSceneMode.Additive);
      loadSceneAsync.allowSceneActivation = true;
      MainSceneRenderersSetActive(false);
      await loadSceneAsync;
    }

    private void MainSceneRenderersSetActive(bool active)
    {
      _cameraService.LevelCamera.gameObject.SetActive(active);
      _parentsProvider.ParentForUI.gameObject.SetActive(active);
      _parentsProvider.ParentForGameplay.gameObject.SetActive(active);
    }
  }
}