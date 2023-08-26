using System;
using System.Collections.Generic;
using System.Linq;

namespace Code.Data
{
  [Serializable]
  public class LevelData
  {
    public int CurrentLevelIndex;
    public List<CompletedLevel> CompletedLevels;


    public LevelData()
    {
      CompletedLevels = new List<CompletedLevel>();
    }

    public void ManageCompletedLevel(int levelIndex, int percentage)
    {
      if(IsLevelCompleted(levelIndex))
      {
        CompletedLevel previousData = CompletedLevel(levelIndex);
        if (previousData.Percentage < percentage)
          previousData.Percentage = percentage;
      }
      else
        CompletedLevels.Add(new CompletedLevel(levelIndex, percentage));
    }

    public CompletedLevel CompletedLevel(int levelIndex) => 
      CompletedLevels.First(completedLevel => completedLevel.Index == levelIndex);

    public bool IsLevelCompleted(int levelIndex) => 
      CompletedLevels.FirstOrDefault(completedLevel => completedLevel.Index == levelIndex) != default;
  }
}