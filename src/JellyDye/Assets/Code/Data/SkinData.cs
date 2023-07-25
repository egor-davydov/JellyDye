using System;
using Code.Gameplay.UI.MainMenu.Skins;

namespace Code.Data
{
  [Serializable]
  public class SkinData
  {
    public event Action Changed;
    public SkinType EquippedSkin { get; private set; } = SkinType.Default;

    public void EquipSkin(SkinType skinType)
    {
      EquippedSkin = skinType;
      Changed?.Invoke();
    }
  }
}