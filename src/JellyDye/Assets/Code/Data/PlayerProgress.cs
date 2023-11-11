using System;

namespace Code.Data
{
  [Serializable]
  public class PlayerProgress
  {
    public SkinData SkinData;
    public LevelData LevelData;

    public PlayerProgress(string startLevelId)
    {
      SkinData = new SkinData();
      LevelData = new LevelData(startLevelId);
    }
  }
}