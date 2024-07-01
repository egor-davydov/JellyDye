using Code.Gameplay.Syringe;
using UnityEngine;

namespace Code.Services.Providers
{
  public class SyringeProvider
  {
    public GameObject SyringeObject { get; private set; }
    public SyringeInjection SyringeInjection { get; private set; }
    public SyringePaintColor SyringePaintColor { get; private set; }

    public void Initialize(GameObject syringeObject)
    {
      SyringeObject = syringeObject;
      SyringeInjection = SyringeObject.GetComponent<SyringeInjection>();
      SyringePaintColor = SyringeObject.GetComponent<SyringePaintColor>();
    }
  }
}