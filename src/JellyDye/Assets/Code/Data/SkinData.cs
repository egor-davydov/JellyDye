using System;
using System.Collections.Generic;
using Code.Enums;

namespace Code.Data
{
  [Serializable]
  public class SkinData
  {
    public SkinType EquippedSkin = SkinType.Default;
    public float NextSkinProgress;
    public List<SkinType> OpenedSkins;

    public event Action Changed;

    public SkinData(int countOfSkins)
    {
      OpenedSkins = new List<SkinType>(countOfSkins)
      {
        SkinType.Default
      };
    }

    public void UpdateNextSkinProgress(bool isProgressBarFilled, float increaseAmount)
    {
      if (!isProgressBarFilled)
        NextSkinProgress += increaseAmount;
      else
      {
        NextSkinProgress += increaseAmount - 1;
      }
    }

    public void OpenSkin(SkinType skinType) =>
      OpenedSkins.Add(skinType);

    public bool IsPlayerHaveSkin(SkinType observableSkinType) =>
      OpenedSkins.Contains(observableSkinType);

    public void EquipSkin(SkinType skinType)
    {
      EquippedSkin = skinType;
      Changed?.Invoke();
    }
  }
}