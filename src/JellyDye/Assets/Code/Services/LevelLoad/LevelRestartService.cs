using Code.Services.Providers;
using Cysharp.Threading.Tasks;
using Fluxy;
using UnityEngine;

namespace Code.Services.LevelLoad
{
  public class LevelRestartService
  {
    private readonly WindowsProvider _windowsProvider;
    private readonly SyringeProvider _syringeProvider;
    private readonly HudProvider _hudProvider;
    private readonly CameraProvider _cameraProvider;
    private readonly FinishButtonService _finishButtonService;
    private readonly SyringeService _syringeService;
    private readonly WindowsService _windowsService;

    private FluxyTarget[] _clearTargets;
    private FluxyContainer[] _fluxyContainers;

    public LevelRestartService(WindowsProvider windowsProvider, SyringeProvider syringeProvider, HudProvider hudProvider,
      CameraProvider cameraProvider, FinishButtonService finishButtonService, SyringeService syringeService,
      WindowsService windowsService)
    {
      _windowsProvider = windowsProvider;
      _syringeProvider = syringeProvider;
      _hudProvider = hudProvider;
      _cameraProvider = cameraProvider;
      _finishButtonService = finishButtonService;
      _syringeService = syringeService;
      _windowsService = windowsService;
    }

    private bool IsFinishState => _windowsProvider.FinishWindow.IsOpen;

    public void Initialize(GameObject jelliesObject)
    {
      _clearTargets = jelliesObject.GetComponentsInChildren<FluxyTarget>(includeInactive: true);
      _fluxyContainers = jelliesObject.GetComponentsInChildren<FluxyContainer>();
    }

    public async UniTask RestartCurrentLevel()
    {
      ResetFinishObjectsIfFinished();
      _windowsService.CloseWindowsIfOpened();

      await _syringeService.SwapSkinIfChanged();
      _syringeService.ResetSyringe();
      ReShuffleJars();

      await ClearJelliesAsync();
      _finishButtonService.Reset();
    }

    public void ResetFinishObjectsIfFinished()
    {
      if (!IsFinishState)
        return;

      _cameraProvider.LevelCamera.MoveToStart();
      _hudProvider.HudObject.SetActive(true);
      _syringeProvider.SyringeObject.SetActive(true);
    }

    private void ReShuffleJars()
    {
      _hudProvider.JarsContainer.ReShuffleJars();
      _hudProvider.JarsContainer.SelectFirstJar();
    }

    private async UniTask ClearJelliesAsync()
    {
      SetActiveClear(true);
      await UniTask.WaitForEndOfFrame();
      SetActiveClear(false);
      foreach (FluxyContainer fluxyContainer in _fluxyContainers)
        fluxyContainer.HasPaint = false;
    }

    private void SetActiveClear(bool active)
    {
      foreach (FluxyTarget clearTarget in _clearTargets)
        clearTarget.gameObject.SetActive(active);
      foreach (FluxyContainer fluxyContainer in _fluxyContainers)
        fluxyContainer.UseMeshProjection = !active;
    }
  }
}