using Code.Gameplay.UI.FinishWindow;
using Code.Services.Factories.UI;
using Code.Services.Providers;
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
    private readonly SyringeProvider _syringeProvider;
    private readonly HudProvider _hudProvider;

    private Texture2D _screenshotWithGround;

    public bool CanFinish { get; private set; }

    public FinishLevelService(PaintCountCalculationService paintCountCalculationService,
      GreenButtonFactory greenButtonFactory, CameraService cameraService,
      ScreenshotService screenshotService, WindowFactory windowFactory,
      SyringeProvider syringeProvider, HudProvider hudProvider)
    {
      _paintCountCalculationService = paintCountCalculationService;
      _greenButtonFactory = greenButtonFactory;
      _cameraService = cameraService;
      _screenshotService = screenshotService;
      _windowFactory = windowFactory;
      _syringeProvider = syringeProvider;
      _hudProvider = hudProvider;
    }

    public void Initialize()
    {
      CanFinish = false;
    }

    public void CheckPaint()
    {
      if (!_paintCountCalculationService.HasPaintOnAllMeshes())
        return;

      CanFinish = true;
      _greenButtonFactory.CreateFinishButton(_hudProvider.HudObject.transform);
    }

    public void FinishLevel()
    {
      Object.Destroy(_hudProvider.HudObject);
      Object.Destroy(_syringeProvider.SyringeObject);
      _cameraService.MoveToFinish().OnComplete(ShowPhotoFlash);
    }

    private void ShowPhotoFlash() => 
      _cameraService.ShowPhotoFlash(onFlashEnd: TakeScreenshot);

    private void TakeScreenshot() => 
      _screenshotService.TakeScreenshot(onTake: CreateFinishWindow);

    private void TakeScreenshotWithoutGround()
    {
      _screenshotWithGround = _screenshotService.ScreenshotTexture;
      _screenshotService.TakeScreenshot(onTake: CreateFinishWindow);
    }

    private async void CreateFinishWindow()
    {
      GameObject finishWindow = await _windowFactory.CreateFinishWindow();
      finishWindow.GetComponent<FinishWindow>().Initialize(_screenshotService.ScreenshotTexture);
    }
  }
}