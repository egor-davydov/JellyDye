using Code.Services.Factories.UI;
using Code.Services.Providers;
using Cysharp.Threading.Tasks;

namespace Code.Services
{
  public class FinishButtonService
  {
    private readonly PaintCountCalculationService _paintCountCalculationService;
    private readonly AnimatedButtonFactory _animatedButtonFactory;
    private readonly HudProvider _hudProvider;

    public bool FinishButtonCreated { get; private set; }

    public FinishButtonService(PaintCountCalculationService paintCountCalculationService,
      AnimatedButtonFactory animatedButtonFactory, HudProvider hudProvider)
    {
      _paintCountCalculationService = paintCountCalculationService;
      _animatedButtonFactory = animatedButtonFactory;
      _hudProvider = hudProvider;
    }

    public void Initialize()
    {
      FinishButtonCreated = false;
    }

    public void CreateFinishButtonIfAllMeshesPainted()
    {
      if (!_paintCountCalculationService.HasPaintOnAllMeshes())
        return;

      FinishButtonCreated = true;
      _animatedButtonFactory.CreateFinishButton(_hudProvider.HudObject.transform).Forget();
    }
  }
}