using Code.Gameplay.Hud;
using Code.Services.Factories;
using UnityEngine;

namespace Code.Services
{
  public class FinishLevelService
  {
    private readonly PaintCountCalculationService _paintCountCalculationService;
    private readonly FinishButtonFactory _finishButtonFactory;
    private GameObject _hudObject;
    private GameObject _syringeObject;

    public bool CanFinish { get; private set; }

    public FinishLevelService(PaintCountCalculationService paintCountCalculationService, FinishButtonFactory finishButtonFactory)
    {
      _paintCountCalculationService = paintCountCalculationService;
      _finishButtonFactory = finishButtonFactory;
    }

    public void Initialize(GameObject hudObject, GameObject syringeObject)
    {
      _syringeObject = syringeObject;
      _hudObject = hudObject;
      CanFinish = false;
    }

    public void CheckPaint()
    {
      if (!_paintCountCalculationService.HasPaintOnAllMeshes())
        return;

      CanFinish = true;
      GameObject finishButton = _finishButtonFactory.CreateFinishButton(_hudObject.transform);
      finishButton.GetComponent<FinishButton>().Initialize(_hudObject, _syringeObject);
    }
  }
}