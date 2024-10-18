using System.Threading;
using System.Threading.Tasks;
using Code.Constants;
using Code.Gameplay.UI.MainMenu.Skins;
using Code.Services.Factories;
using Code.Services.Providers;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Code.Services
{
  public class NewSkinSceneService
  {
    private const short RotationAngle = -60;
    private readonly CameraService _cameraService;
    private readonly ParentsProvider _parentsProvider;
    private readonly SyringeFactory _syringeFactory;
    private readonly InputService _inputService;

    private Transform _newSkinStandTransform;
    private readonly CancellationTokenSource _cts;
    private Vector3 _skinRotationPoint;

    public NewSkinSceneService(CameraService cameraService, ParentsProvider parentsProvider,
      SyringeFactory syringeFactory, InputService inputService)
    {
      _parentsProvider = parentsProvider;
      _syringeFactory = syringeFactory;
      _inputService = inputService;
      _cameraService = cameraService;
      _cts = new CancellationTokenSource();
    }

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
          syringeObject.transform.RotateAround(_skinRotationPoint, Vector3.up, RotationAngle * Time.deltaTime);
          await UniTask.Yield(PlayerLoopTiming.Update, _cts.Token);
        }
        //if(_inputService.IsUserPressedInputInGameSpace)
          
      }
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
    }
  }
}