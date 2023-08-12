using System;
using Code.Gameplay.UI.MainMenu.Skins;

namespace Code.Data
{
  [Serializable]
  public class PlayerProgress
  {
    public int CurrentLevel;
    public SkinData SkinData;

    public PlayerProgress(SkinType startSkinType)
    {
      SkinData = new SkinData(startSkinType);
    }
  }
}