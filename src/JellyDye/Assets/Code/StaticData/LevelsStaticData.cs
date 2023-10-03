using System;
using System.Linq;
using UnityEngine;

namespace Code.StaticData
{
  [CreateAssetMenu(menuName = "StaticData/Levels", fileName = "Levels", order = 0)]
  public class LevelsStaticData : ScriptableObject
  {
    public LevelConfig[] LevelConfigs;

    private void OnValidate()
    {
      foreach (LevelConfig levelConfig in LevelConfigs)
      {
        if (String.IsNullOrEmpty(levelConfig.Id))
          throw new Exception($"No id for jelly {levelConfig.JelliesPrefab.name}");
      }
    }

    public int GetLevelIndex(string id)
    {
      for (int i = 0; i < LevelConfigs.Length; i++)
      {
        if (LevelConfigs[i].Id == id)
          return i;
      }

      throw new Exception($"Can't find level index of id \"{id}\"");
    }

    public LevelConfig GetConfigByLevelId(string levelId) =>
      LevelConfigs.First(config => config.Id == levelId);
  }
}