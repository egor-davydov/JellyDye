using System;
using System.Collections.Generic;
using Code.Gameplay.UI.MainMenu.Skins;

namespace Code.Data
{
  [Serializable]
  public class PlayerProgress
  {
    public int CurrentLevel;
    public SkinData SkinData;

    public PlayerProgress(SkinType startSkinType, List<SkinType> openedSkins)
    {
      SkinData = new SkinData(startSkinType, openedSkins);
    }
  }
}