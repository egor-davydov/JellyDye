using System.Threading;
using System.Threading.Tasks;
using Code.Constants;
using Code.Gameplay.Syringe;
using Code.Gameplay.UI.MainMenu.Skins;
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
    private readonly CancellationTokenSource _cts;

    private Transform _newSkinStandTransform;
    private Vector3 _skinRotationPoint;

    private bool _isRotating;
    private Vector3 _previousMousePosition;
    private Vector2 _currentRotationVelocity;
    private Vector2 _lastRotationVelocity;

    public NewSkinSceneService(CameraService cameraService, ParentsProvider parentsProvider,
      SyringeFactory syringeFactory, InputService inputService, StaticDataService staticDataService)
    {
      _parentsProvider = parentsProvider;
      _syringeFactory = syringeFactory;
      _inputService = inputService;
      _staticDataService = staticDataService;
      _cameraService = cameraService;
      _cts = new CancellationTokenSource();
    }

    private NewSkinSceneConfig NewSkinSceneConfig => _staticDataService.ForSkins().NewSkinSceneConfig;

    public void Initialize(Transform newSkinStandTransform, Vector3 skinRotationPoint)
    {
      _skinRotationPoint = skinRotationPoint;
      _newSkinStandTransform = newSkinStandTransform;
    }

    public async UniTask ShowSkinScene(SkinType skinType)
    {
      await LoadSceneAndDisableMainSceneRenderers();
      GameObject syringeObject = await _syringeFactory.CreateSyringe(skinType, _newSkinStandTransform);
      syringeObject.transform.localPosition = Vector3.zero;
      syringeObject.transform.localRotation = Quaternion.identity;
      syringeObject.transform.localScale = Vector3.one;
      Object.Destroy(syringeObject.GetComponent<SyringeLiquidColor>());
      Object.Destroy(syringeObject.GetComponent<SyringeMove>());
      StartSkinRotation(syringeObject).Forget();
    }

    public async UniTask HideSkinScene()
    {
      StopSkinRotation();
      MainSceneRenderersSetActive(true);
      SceneManager.SetActiveScene(SceneManager.GetSceneByName(SceneName.Main));
      await SceneManager.UnloadSceneAsync(SceneName.NewSkin);
    }

    private async UniTaskVoid StartSkinRotation(GameObject syringeObject)
    {
      bool isAutoRotating = true;
      while (true)
      {
        if (isAutoRotating)
        {
          syringeObject.transform.RotateAround(_skinRotationPoint, Vector3.up,
            -NewSkinSceneConfig.AutoRotationSpeed * Time.deltaTime);
        }

        if (_inputService.IsInputButtonPressed)
        {
          isAutoRotating = false;
          _isRotating = true;
          _previousMousePosition = Input.mousePosition;
        }

        if (_inputService.IsInputButtonReleased)
        {
          _isRotating = false;
          _lastRotationVelocity = _currentRotationVelocity;
        }

        if (_isRotating)
        {
          Vector3 mouseDelta = Input.mousePosition - _previousMousePosition;

          float rotationY = -mouseDelta.x * NewSkinSceneConfig.RotationSpeed * Time.deltaTime;
          float rotationX = -mouseDelta.y * NewSkinSceneConfig.RotationSpeed * Time.deltaTime;

          _currentRotationVelocity = new Vector2(rotationX, rotationY);

          RotateWithVelocity(syringeObject, _currentRotationVelocity);

          _previousMousePosition = Input.mousePosition;
        }
        else if (_lastRotationVelocity != Vector2.zero)
        {
          float dampingFactor = 1f - (NewSkinSceneConfig.InertiaDamping * Time.deltaTime);
          _lastRotationVelocity *= dampingFactor;

          if (_lastRotationVelocity.sqrMagnitude < 0.01f)
            _lastRotationVelocity = Vector2.zero;

          RotateWithVelocity(syringeObject, _lastRotationVelocity);
        }

        await UniTask.Yield(PlayerLoopTiming.Update, _cts.Token);
      }
    }

    private void RotateWithVelocity(GameObject rotationObject, Vector2 rotationVelocity)
    {
      rotationObject.transform.RotateAround(_skinRotationPoint, Vector3.up, rotationVelocity.y);
      rotationObject.transform.RotateAround(_skinRotationPoint, Vector3.right, rotationVelocity.x);
    }

    private void StopSkinRotation() =>
      _cts.Cancel();

    private async Task LoadSceneAndDisableMainSceneRenderers()
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