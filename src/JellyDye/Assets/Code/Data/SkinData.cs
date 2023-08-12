using System;
using Code.Gameplay.UI.MainMenu.Skins;

namespace Code.Data
{
  [Serializable]
  public class SkinData
  {
    public SkinType EquippedSkin;
    public event Action Changed;

    public SkinData(SkinType startSkinType)
    {
      EquippedSkin = startSkinType;
    }

    public void EquipSkin(SkinType skinType)
    {
      EquippedSkin = skinType;
      Changed?.Invoke();
    }
  }
}