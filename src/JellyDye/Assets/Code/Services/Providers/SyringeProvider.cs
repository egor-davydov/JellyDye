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
    public SyringeMove SyringeMove { get; private set; }
    public SyringeAudio SyringeAudio { get; private set; }

    public void Initialize(Syringe syringe)
    {
      Syringe = syringe;
      SyringeObject = syringe.gameObject;
      SyringeLiquidColor = SyringeObject.GetComponent<SyringeLiquidColor>();
      SyringePistonAndLiquid = SyringeObject.GetComponent<SyringePistonAndLiquid>();
      SyringeMove = SyringeObject.GetComponent<SyringeMove>();
      SyringeAudio = SyringeObject.GetComponent<SyringeAudio>();
    }
  }
}