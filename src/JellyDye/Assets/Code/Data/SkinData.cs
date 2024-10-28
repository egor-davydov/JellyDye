using System;
using System.Collections.Generic;
using Code.Gameplay.UI.MainMenu.Skins;

namespace Code.Data
{
  [Serializable]
  public class SkinData
  {
    public SkinType EquippedSkin = SkinType.Default;
    public float NextSkinProgress;
    public List<SkinType> OpenedSkins;

    public SkinData(int countOfSkins)
    {
      OpenedSkins = new List<SkinType>(countOfSkins)
      {
        SkinType.Default
      };
    }

    public event Action Changed;

    public void EquipSkin(SkinType skinType)
    {
      EquippedSkin = skinType;
      Changed?.Invoke();
    }
  }
}