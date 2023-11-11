using System;
using System.Collections.Generic;
using System.Linq;

namespace Code.Data
{
  [Serializable]
  public class LevelData
  {
    public string CurrentLevelId;
    public List<CompletedLevel> CompletedLevels;
    
    public LevelData(string startLevelId)
    {
      CurrentLevelId = startLevelId;
      CompletedLevels = new List<CompletedLevel>();
    }

    public void ManageCompletedLevel(string levelId, int percentage)
    {
      if(IsLevelCompleted(levelId))
      {
        CompletedLevel previousData = CompletedLevel(levelId);
        if (previousData.Percentage < percentage)
          previousData.Percentage = percentage;
      }
      else
        CompletedLevels.Add(new CompletedLevel(levelId, percentage));
    }

    public CompletedLevel CompletedLevel(string levelId) => 
      CompletedLevels.First(completedLevel => completedLevel.Id == levelId);

    public bool IsLevelCompleted(string levelId) => 
      CompletedLevels.FirstOrDefault(completedLevel => completedLevel.Id == levelId) != default;
  }
}