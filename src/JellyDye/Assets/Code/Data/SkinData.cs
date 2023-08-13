using System;
using System.Collections.Generic;
using Code.Gameplay.UI.MainMenu.Skins;

namespace Code.Data
{
  [Serializable]
  public class SkinData
  {
    public float NextSkinProgress;
    public List<SkinType> OpenedSkins;
    public SkinType EquippedSkin;
    public event Action Changed;

    public SkinData(SkinType startSkinType, List<SkinType> openedSkins)
    {
      OpenedSkins = openedSkins;
      EquippedSkin = startSkinType;
    }

    public void EquipSkin(SkinType skinType)
    {
      EquippedSkin = skinType;
      Changed?.Invoke();
    }
  }
}