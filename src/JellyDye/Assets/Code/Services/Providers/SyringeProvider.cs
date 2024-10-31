using Code.Gameplay.Syringe;
using UnityEngine;

namespace Code.Services.Providers
{
  public class SyringeProvider
  {
    public GameObject SyringeObject { get; private set; }
    public SyringeInjection SyringeInjection { get; private set; }
    public SyringeLiquidColor SyringeLiquidColor { get; private set; }

    public void Initialize(GameObject syringeObject)
    {
      SyringeObject = syringeObject;
      SyringeInjection = SyringeObject.GetComponent<SyringeInjection>();
      SyringeLiquidColor = SyringeObject.GetComponent<SyringeLiquidColor>();
    }
  }
}