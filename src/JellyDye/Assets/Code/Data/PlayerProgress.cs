using System;
using System.Collections.Generic;
using Code.Gameplay.UI.MainMenu.Skins;

namespace Code.Data
{
  [Serializable]
  public class PlayerProgress
  {
    public SkinData SkinData;
    public LevelData LevelData;

    public PlayerProgress()
    {
      SkinData = new SkinData();
      LevelData = new LevelData();
    }
  }
}