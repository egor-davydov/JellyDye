using Code.Gameplay.UI.Hud;
using Code.Gameplay.UI.Hud.PaintChange;
using UnityEngine;

namespace Code.Services.Providers
{
  public class HudProvider
  {
    public GameObject HudObject { get; private set; }
    public JarsContainer JarsContainer { get; private set; }
    public InjectionButton InjectionButton { get; private set; }

    public void Initialize(GameObject hudObject)
    {
      HudObject = hudObject;
      JarsContainer = HudObject.GetComponentInChildren<JarsContainer>();
      InjectionButton = HudObject.GetComponentInChildren<InjectionButton>();
    }
  }
}