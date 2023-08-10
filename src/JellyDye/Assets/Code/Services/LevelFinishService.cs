using System;
using Code.Gameplay.Hud;
using Code.Gameplay.Syringe;
using Code.Services.Factories;
using UnityEngine;

namespace Code.Services
{
  public class LevelFinishService : IDisposable
  {
    private readonly PaintCountCalculationService _paintCountCalculationService;
    private readonly FinishButtonFactory _finishButtonFactory;
    private PaintInjection _paintInjection;
    private GameObject _hudObject;
    private GameObject _syringeObject;

    public LevelFinishService(PaintCountCalculationService paintCountCalculationService, FinishButtonFactory finishButtonFactory)
    {
      _paintCountCalculationService = paintCountCalculationService;
      _finishButtonFactory = finishButtonFactory;
    }
    
    public void Initialize(PaintInjection paintInjection, GameObject hudObject, GameObject syringeObject)
    {
      _syringeObject = syringeObject;
      _hudObject = hudObject;
      _paintInjection = paintInjection;
      _paintInjection.OnFirstPaint += CheckPaint;
    }

    public void Dispose() => 
      _paintInjection.OnFirstPaint -= CheckPaint;

    private void CheckPaint()
    {
      if (!_paintCountCalculationService.HasPaintOnAllMeshes())
        return;

      _paintInjection.OnFirstPaint -= CheckPaint;
      GameObject finishButton = _finishButtonFactory.CreateFinishButton(_hudObject.transform);
      finishButton.GetComponent<FinishButton>().Initialize(_hudObject, _syringeObject);
    }
  }
}