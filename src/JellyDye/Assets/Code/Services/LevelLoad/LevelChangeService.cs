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
    private readonly HudProvider _hudProvider;
    private readonly LevelRestartService _levelRestartService;
    private readonly SyringeService _syringeService;
    private readonly WindowsService _windowsService;

    private GameObject _currentJelliesObject;

    public LevelChangeService(JelliesFactory jelliesFactory, PaintCountCalculationService paintCountCalculationService,
      FinishButtonService finishButtonService, HudProvider hudProvider, LevelRestartService levelRestartService,
      SyringeService syringeService, WindowsService windowsService)
    {
      _jelliesFactory = jelliesFactory;
      _paintCountCalculationService = paintCountCalculationService;
      _finishButtonService = finishButtonService;
      _hudProvider = hudProvider;
      _levelRestartService = levelRestartService;
      _syringeService = syringeService;
      _windowsService = windowsService;
    }

    public void Initialize(GameObject jelliesObject)
    {
      _currentJelliesObject = jelliesObject;
    }

    public async UniTask ChangeLevel(string levelId)
    {
      _levelRestartService.ResetFinishObjectsIfFinished();
      _windowsService.CloseWindowsIfOpened();

      await _syringeService.SwapSkinIfChanged();
      _syringeService.ResetSyringe();
      await ChangeJelly(levelId);
      _levelRestartService.Initialize(_currentJelliesObject);
      _paintCountCalculationService.Initialize(_currentJelliesObject);
      _hudProvider.JarsContainer.DestroyJars();
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