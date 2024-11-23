﻿using System;
using System.Collections.Generic;
using UnityEngine;

namespace Code.StaticData.Level
{
  [CreateAssetMenu(menuName = "StaticData/Levels", fileName = "Levels", order = 0)]
  public class LevelsStaticData : ScriptableObject
  {
    private const int RangeMinResolution = 6;
    private const int RangeMaxResolution = 19;
    public float ColorCompareEpsilon = 0.4f;
    [field: SerializeField] public bool FinishLevelImmediately { get; private set; }
    [field: SerializeField] public bool OpenNewSkin { get; private set; }
    [field: SerializeField] public bool IsShowingNames { get; private set; }

    [field: SerializeField, Range(RangeMinResolution, RangeMaxResolution)]
    public int MinGeneratedResolution { get; private set; }

    [field: SerializeField, Range(RangeMinResolution + 1, RangeMaxResolution + 1)]
    public int MaxGeneratedResolution { get; private set; }

    [field: SerializeField] public int VerticesCountToGenerateOneObiParticle { get; private set; }
    public LevelConfig[] LevelConfigs;

    #region ValidateLevelsData

    public void OnValidate()
    {
      for (var index = 0; index < LevelConfigs.Length; index++)
      {
        LevelConfig levelConfig = LevelConfigs[index];
        ValidateLevelId(levelConfig, index + 1);
        ValidateMinMax();
        //AddTargetColorIfNeed(levelConfig);
        //RemoveSimilarColorsByEpsilon(levelConfig);
      }
    }

    private void ValidateMinMax()
    {
      if (MaxGeneratedResolution <= MinGeneratedResolution)
      {
        MaxGeneratedResolution
          = Mathf.Clamp(MinGeneratedResolution + 1, RangeMinResolution + 1, RangeMaxResolution + 1);
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

    private void ValidateLevelId(LevelConfig levelConfig, int levelNumber)
    {
      if (levelConfig.Id.Contains(' '))
        levelConfig.Id = levelConfig.Id.Replace(' ', '_');
      if (string.IsNullOrEmpty(levelConfig.Id))
        throw new Exception($"No id for \"{levelNumber}\" level");
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

#if UNITY_EDITOR
    public JellyMeshConfig GetJellyConfigByMesh(Mesh mesh) //use only in editor, use LevelConfig
    {
      foreach (LevelConfig levelConfig in LevelConfigs)
      {
        foreach (JellyMeshConfig jellyMeshConfig in levelConfig.JellyMeshConfigs)
        {
          if (jellyMeshConfig.MeshReference.editorAsset == mesh || jellyMeshConfig.MeshReference.SubObjectName == mesh.name)
            return jellyMeshConfig;
        }
      }

      throw new Exception($"Error in method GetJellyConfigByMesh. Cant find JellyMeshConfig for mesh \"{mesh}\"");
    }
#endif
  }
}