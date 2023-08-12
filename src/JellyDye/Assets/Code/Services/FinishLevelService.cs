using System.Collections;
using Code.Infrastructure;
using Code.Services.Factories.UI;
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
    private readonly ICoroutineRunner _coroutineRunner;
    private GameObject _hudObject;
    private GameObject _syringeObject;

    public bool CanFinish { get; private set; }

    public FinishLevelService(PaintCountCalculationService paintCountCalculationService, GreenButtonFactory greenButtonFactory,
      CameraService cameraService, ScreenshotService screenshotService, WindowFactory windowFactory, ICoroutineRunner coroutineRunner)
    {
      _paintCountCalculationService = paintCountCalculationService;
      _greenButtonFactory = greenButtonFactory;
      _cameraService = cameraService;
      _screenshotService = screenshotService;
      _windowFactory = windowFactory;
      _coroutineRunner = coroutineRunner;
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
      _cameraService.MoveToFinish().OnComplete(OnMoveDone);
    }

    private void OnMoveDone()
    {
      _screenshotService.TakeScreenshot();
      _coroutineRunner.StartCoroutine(WaitForScreenshot());
    }

    private IEnumerator WaitForScreenshot()
    {
      while (_screenshotService.IsScreenshotCaptured == false)
        yield return null;
      _windowFactory.CreateFinishWindow();
    }
  }
}