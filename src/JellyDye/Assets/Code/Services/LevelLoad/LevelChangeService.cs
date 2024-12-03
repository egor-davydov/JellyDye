using Code.Gameplay.UI.FinishWindow;
using Code.Services.Factories;
using Code.Services.Providers;
using Cysharp.Threading.Tasks;
using UnityEngine;

namespace Code.Services.LevelLoad
{
  public class LevelChangeService
  {
    private readonly JelliesFactory _jelliesFactory;
    private readonly PaintCountCalculationService _paintCountCalculationService;
    private readonly FinishButtonService _finishButtonService;
    private readonly SyringeProvider _syringeProvider;
    private readonly HudProvider _hudProvider;
    private readonly LevelRestartService _levelRestartService;
    private readonly SyringeService _syringeService;
    private readonly WindowsProvider _windowsProvider;
    private readonly CameraProvider _cameraProvider;

    private GameObject _currentJelliesObject;

    public LevelChangeService(JelliesFactory jelliesFactory, PaintCountCalculationService paintCountCalculationService,
      FinishButtonService finishButtonService, SyringeProvider syringeProvider, HudProvider hudProvider,
      LevelRestartService levelRestartService, SyringeService syringeService, WindowsProvider windowsProvider,
      CameraProvider cameraProvider)
    {
      _jelliesFactory = jelliesFactory;
      _paintCountCalculationService = paintCountCalculationService;
      _finishButtonService = finishButtonService;
      _syringeProvider = syringeProvider;
      _hudProvider = hudProvider;
      _levelRestartService = levelRestartService;
      _syringeService = syringeService;
      _windowsProvider = windowsProvider;
      _cameraProvider = cameraProvider;
    }

    public void Initialize(GameObject jelliesObject)
    {
      _currentJelliesObject = jelliesObject;
    }

    public async UniTask ChangeLevel(string levelId)
    {
      GameObject mainMenu = _windowsProvider.MainMenu;
      if (mainMenu != null)
        Object.Destroy(mainMenu.gameObject);

      FinishWindow finishWindow = _windowsProvider.FinishWindow;
      if (finishWindow != null)
      {
        Object.Destroy(finishWindow.gameObject);
        _cameraProvider.LevelCamera.MoveToStart();
        _hudProvider.HudObject.SetActive(true);
        _syringeProvider.SyringeObject.SetActive(true);
      }

      await _syringeService.SwapSkinIfChanged();
      _syringeService.ResetSyringe();
      await ChangeJelly(levelId);
      _levelRestartService.Initialize(_currentJelliesObject);
      _paintCountCalculationService.Initialize(_currentJelliesObject);
      _hudProvider.JarsContainer.ClearFromJars();
      _hudProvider.JarsContainer.InitializeAndCreateJars(levelId).Forget();
      _hudProvider.ScreenshotTargetColors.Initialize(levelId);
      _finishButtonService.Reset();
    }

    private async UniTask ChangeJelly(string levelId)
    {
      Object.Destroy(_currentJelliesObject);
      _currentJelliesObject = await _jelliesFactory.CreateJelly(levelId);
    }
  }
}