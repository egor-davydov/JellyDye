using Code.Gameplay.UI.FinishWindow;
using Code.Services.Factories.UI;
using Cysharp.Threading.Tasks;
using DG.Tweening;
using UnityEngine;

namespace Code.Services
{
  public class FinishLevelService
  {
    private readonly PaintCountCalculationService _paintCountCalculationService;
    private readonly GreenButtonFactory _greenButtonFactory;
    private readonly CameraService _cameraService;
    private readonly ScreenshotService _screenshotService;
    private readonly WindowFactory _windowFactory;
    
    private GameObject _hudObject;
    private GameObject _syringeObject;
    private Texture2D _screenshot;

    public bool CanFinish { get; private set; }

    public FinishLevelService(PaintCountCalculationService paintCountCalculationService, GreenButtonFactory greenButtonFactory,
      CameraService cameraService, ScreenshotService screenshotService, WindowFactory windowFactory)
    {
      _paintCountCalculationService = paintCountCalculationService;
      _greenButtonFactory = greenButtonFactory;
      _cameraService = cameraService;
      _screenshotService = screenshotService;
      _windowFactory = windowFactory;
    }

    public void Initialize(GameObject hudObject, GameObject syringeObject)
    {
      _hudObject = hudObject;
      _syringeObject = syringeObject;
      CanFinish = false;
    }

    public void CheckPaint()
    {
      if (!_paintCountCalculationService.HasPaintOnAllMeshes())
        return;

      CanFinish = true;
      _greenButtonFactory.CreateFinishButton(_hudObject.transform);
    }

    public void FinishLevel()
    {
      Object.Destroy(_hudObject);
      Object.Destroy(_syringeObject);
      _cameraService.MoveToFinish().OnComplete(ShowPhotoFlash);
    }

    private void ShowPhotoFlash() => 
      _cameraService.ShowPhotoFlash(onFlashEnd: TakeScreenshot);

    private void TakeScreenshot() => 
      _screenshotService.TakeScreenshot(onTake: CreateFinishWindow);

    private void TakeScreenshotWithoutGround()
    {
      _screenshot = _screenshotService.ScreenshotTexture;
      _screenshotService.TakeScreenshot(onTake: CreateFinishWindow);
    }

    private async void CreateFinishWindow()
    {
      GameObject finishWindow = await _windowFactory.CreateFinishWindow();
      finishWindow.GetComponent<FinishWindow>().Initialize(_screenshotService.ScreenshotTexture);
    }
  }
}