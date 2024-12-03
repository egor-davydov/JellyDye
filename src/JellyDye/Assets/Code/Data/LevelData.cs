using System;
using System.Collections.Generic;

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

    public event Action<string> CompletedLevelsChanged;

    public void ManageCompletedLevel(string levelId, int percentage)
    {
      if (IsLevelAlreadyInProgress(levelId))
      {
        CompletedLevel previousData = CompletedLevel(levelId);
        if (previousData.Percentage < percentage)
        {
          previousData.Percentage = percentage;
          CompletedLevelsChanged?.Invoke(levelId);
        }
      }
      else
      {
        CompletedLevels.Add(new CompletedLevel(levelId, percentage));
        CompletedLevelsChanged?.Invoke(levelId);
      }
    }

    public CompletedLevel CompletedLevel(string levelId)
    {
      foreach (CompletedLevel completedLevel in CompletedLevels)
      {
        if (completedLevel.Id == levelId)
          return completedLevel;
      }

      throw new Exception($"Can't find completed level id=\"{levelId}\"");
    }

    public bool IsLevelAlreadyInProgress(string levelId)
    {
      foreach (CompletedLevel completedLevel in CompletedLevels)
      {
        if (completedLevel.Id == levelId)
          return true;
      }

      return false;
    }
  }
}