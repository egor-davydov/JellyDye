using Code.Services.Providers;

namespace Code.Services
{
  public class FinishButtonService
  {
    private readonly PaintCountCalculationService _paintCountCalculationService;
    private readonly HudProvider _hudProvider;

    public bool FinishButtonAnimated { get; private set; }

    public FinishButtonService(PaintCountCalculationService paintCountCalculationService, HudProvider hudProvider)
    {
      _paintCountCalculationService = paintCountCalculationService;
      _hudProvider = hudProvider;
    }

    public void Reset()
    {
      if (!FinishButtonAnimated)
        return;

      _hudProvider.FinishButton.ResetAnimation();
      FinishButtonAnimated = false;
    }

    public void CreateFinishButtonIfAllMeshesPainted()
    {
      if (!_paintCountCalculationService.HasPaintOnAllMeshes())
        return;

      FinishButtonAnimated = true;
      _hudProvider.FinishButton.Animate();
    }
  }
}