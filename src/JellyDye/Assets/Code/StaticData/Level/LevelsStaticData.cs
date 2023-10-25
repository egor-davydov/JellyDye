using System;
using System.Collections.Generic;
using System.Linq;
using Code.Helpers;
using UnityEngine;

namespace Code.StaticData.Level
{
  [CreateAssetMenu(menuName = "StaticData/Levels", fileName = "Levels", order = 0)]
  public class LevelsStaticData : ScriptableObject
  {
    public float ColorCompareEpsilon = 0.4f;
    public LevelConfig[] LevelConfigs;

    #region ValidateLevelsData

    public void OnValidate()
    {
      foreach (LevelConfig levelConfig in LevelConfigs)
      {
        ValidateLevelId(levelConfig);
        //AddTargetColorIfNeed(levelConfig);
        //RemoveSimilarColorsByEpsilon(levelConfig);
      }
    }


    private Color? ColorOutsideTargetColors(List<Color> targetColors, Color firstColor, Color secondColor)
    {
      if (!targetColors.Contains(firstColor))
        return firstColor;
      if (!targetColors.Contains(secondColor))
        return secondColor;
      return null;
    }

    private void AddTargetColorIfNeed(LevelConfig levelConfig)
    {
      foreach (JellyMeshConfig jellyMeshConfig in levelConfig.JellyMeshConfigs)
      {
        List<Color> targetColors = levelConfig.GetTargetColors;
        if (!targetColors.Contains(jellyMeshConfig.TargetColor))
          targetColors.Add(jellyMeshConfig.TargetColor);
      }
    }

    private void ValidateLevelId(LevelConfig levelConfig)
    {
      if (String.IsNullOrEmpty(levelConfig.Id))
        throw new Exception($"No id for jelly {levelConfig.JelliesPrefab.name}");
    }

    #endregion

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
    public JellyMeshConfig GetJellyConfigByMesh(Mesh mesh)
    {
      foreach (LevelConfig levelConfig in LevelConfigs)
      {
        JellyMeshConfig jellyMeshConfig = levelConfig.JellyMeshConfigs.FirstOrDefault(x => x.Mesh == mesh);
        if(jellyMeshConfig != default)
          return jellyMeshConfig;
      }

      throw new Exception($"Error in method GetJellyConfigByMesh. Cant find JellyMeshConfig for mesh \"{mesh}\"");
    }
  }
}