using Code.Gameplay.Syringe;
using UnityEngine;

namespace Code.Services.Providers
{
  public class SyringeProvider
  {
    public GameObject SyringeObject { get; private set; }
    public Syringe Syringe { get; private set; }
    public SyringePistonAndLiquid SyringePistonAndLiquid { get; private set; }
    public SyringeLiquidColor SyringeLiquidColor { get; private set; }

    public void Initialize(GameObject syringeObject)
    {
      SyringeObject = syringeObject;
      Syringe = SyringeObject.GetComponent<Syringe>();
      SyringeLiquidColor = SyringeObject.GetComponent<SyringeLiquidColor>();
      SyringePistonAndLiquid = SyringeObject.GetComponent<SyringePistonAndLiquid>();
    }
  }
}