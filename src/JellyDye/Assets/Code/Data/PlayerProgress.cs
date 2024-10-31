using System;

namespace Code.Data
{
  [Serializable]
  public class PlayerProgress
  {
    public SkinData SkinData;
    public LevelData LevelData;

    public PlayerProgress(string startLevelId, int countOfSkins)
    {
      SkinData = new SkinData(countOfSkins);
      LevelData = new LevelData(startLevelId);
    }
  }
}