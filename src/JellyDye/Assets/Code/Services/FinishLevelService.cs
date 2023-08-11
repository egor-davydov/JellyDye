using Code.Services.Factories.UI;
using UnityEngine;

namespace Code.Services
{
  public class FinishLevelService
  {
    private readonly PaintCountCalculationService _paintCountCalculationService;
    private readonly GreenButtonFactory _greenButtonFactory;
    private GameObject _hudObject;
    private GameObject _syringeObject;

    public bool CanFinish { get; private set; }

    public FinishLevelService(PaintCountCalculationService paintCountCalculationService, GreenButtonFactory greenButtonFactory)
    {
      _paintCountCalculationService = paintCountCalculationService;
      _greenButtonFactory = greenButtonFactory;
    }

    public void Initialize(GameObject hudObject)
    {
      _hudObject = hudObject;
      CanFinish = false;
    }

    public void CheckPaint()
    {
      if (!_paintCountCalculationService.HasPaintOnAllMeshes())
        return;

      CanFinish = true;
      _greenButtonFactory.CreateFinishButton(_hudObject.transform);
    }
  }
}