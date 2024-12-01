using System.Collections.Generic;
using Code.Extensions;
using Code.Gameplay.UI.FinishWindow;
using Code.Gameplay.UI.Hud.PaintChange;
using Code.Services.Providers;
using Cysharp.Threading.Tasks;
using Fluxy;
using UnityEngine;

namespace Code.Services
{
  public class RestartService
  {
    private readonly StaticDataService _staticData;
    private readonly WindowsProvider _windowsProvider;
    private readonly SyringeProvider _syringeProvider;
    private readonly HudProvider _hudProvider;
    private readonly CameraProvider _cameraProvider;
    private readonly FinishButtonService _finishButtonService;

    private FluxyTarget[] _clearTargets;
    private FluxyContainer[] _fluxyContainers;

    public RestartService(StaticDataService staticData, WindowsProvider windowsProvider, SyringeProvider syringeProvider,
      HudProvider hudProvider, CameraProvider cameraProvider, FinishButtonService finishButtonService)
    {
      _staticData = staticData;
      _windowsProvider = windowsProvider;
      _syringeProvider = syringeProvider;
      _hudProvider = hudProvider;
      _cameraProvider = cameraProvider;
      _finishButtonService = finishButtonService;
    }

    public void Initialize(FluxyContainer[] fluxyContainers, FluxyTarget[] clearTargets)
    {
      _fluxyContainers = fluxyContainers;
      _clearTargets = clearTargets;
    }

    public async UniTask RestartCurrentLevel()
    {
      GameObject mainMenu = _windowsProvider.MainMenu;
      if (mainMenu != null)
      {
        Object.Destroy(mainMenu.gameObject);
      }

      FinishWindow finishWindow = _windowsProvider.FinishWindow;
      if (finishWindow != null)
      {
        Object.Destroy(finishWindow.gameObject);
        _cameraProvider.LevelCamera.MoveToStart();
        _hudProvider.HudObject.SetActive(true);
        _syringeProvider.SyringeObject.SetActive(true);
      }

      _syringeProvider.Syringe.transform.position = _staticData.ForLevels.SyringeStartPosition;
      _syringeProvider.SyringePistonAndLiquid.ResetEither().Forget();
      List<Jar> jars = _hudProvider.JarsContainer.Jars;
      jars.Shuffle();
      for (var index = 0; index < jars.Count; index++)
        jars[index].transform.SetSiblingIndex(index);
      _hudProvider.JarsContainer.SelectFirstJar();

      SetActiveClear(true);
      await UniTask.WaitForEndOfFrame();
      SetActiveClear(false);
      foreach (FluxyContainer fluxyContainer in _fluxyContainers)
        fluxyContainer.HasPaint = false;
      if (_finishButtonService.FinishButtonAnimated)
      {
        _hudProvider.FinishButton.ResetAnimation();
        _finishButtonService.Reset();
      }
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