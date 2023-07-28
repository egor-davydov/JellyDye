using System;

namespace Code.Data
{
  [Serializable]
  public class PlayerProgress
  {
    public int CurrentLevel;
    public SkinData SkinData;

    public PlayerProgress()
    {
      SkinData = new SkinData();
    }
  }
}