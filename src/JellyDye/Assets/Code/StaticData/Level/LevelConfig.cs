using System;
using System.Collections.Generic;
using System.Linq;
using Code.Helpers;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace Code.StaticData.Level
{
  [Serializable]
  public class LevelConfig
  {
    public string Id;
    public List<JellyMeshConfig> JellyMeshConfigs;
    public AssetReference JelliesPrefabReference;
    public List<Color> AdditionalColors;
    public List<Color> AllColorsCached;
    public Texture2D TargetTexture;
    public Texture2D TargetTextureWithGround;

    private IEnumerable<Color> GetTargetColors => JellyMeshConfigs.Select(x => x.TargetColor);
    private List<Color> AllColors => GetTargetColors.Union(AdditionalColors).ToList();
    
    public JellyMeshConfig GetConfigForMesh(Mesh mesh)
    {
      foreach (JellyMeshConfig jellyMeshConfig in JellyMeshConfigs)
      {
        if (jellyMeshConfig.Mesh == mesh)
          return jellyMeshConfig;
      }

      throw new Exception($"Error in LevelConfig method GetConfigForMesh. Can't find JellyMeshConfig for mesh \"{mesh}\"");
    }

    #region ValidateLevelConfig

    

    public void UpdateColors()
    {
      AllColorsCached.Clear();
      AllColorsCached.AddRange(AllColors);
    }
    
    private void AddTargetColorIfNeed()
    {
      foreach (JellyMeshConfig jellyMeshConfig in JellyMeshConfigs)
      {
        List<Color> targetColors = GetTargetColors.ToList();
        if (!targetColors.Contains(jellyMeshConfig.TargetColor))
          targetColors.Add(jellyMeshConfig.TargetColor);
      }
    }

    public void RemoveSimilarColorsByEpsilon( float epsilon)
    {
      List<Color> levelColors = AllColors;
      List<Color> targetColors = GetTargetColors.ToList();
      for (int indexFirst = 0; indexFirst < levelColors.Count; indexFirst++)
      for (int indexSecond = indexFirst + 1; indexSecond < levelColors.Count; indexSecond++)
      {
        Color firstColor = levelColors[indexFirst];
        Color secondColor = levelColors[indexSecond];
        if (MathHelp.VectorsSimilar(firstColor, secondColor, epsilon))
        {
          bool isFirstTargetColor = targetColors.Contains(firstColor);
          bool isSecondTargetColor = targetColors.Contains(secondColor);
          if (isFirstTargetColor && isSecondTargetColor)
            continue;
          if(epsilon > 0.3f)
            Debug.LogWarning($"Removing similar color in level \"{Id}\"\n firstColor=({firstColor}, index={indexFirst});secondColor=({secondColor}, index={indexSecond}); ");
          if (!isFirstTargetColor)
          {
            levelColors.RemoveAt(indexFirst);
            indexSecond--;
            continue;
          }

          levelColors.RemoveAt(indexSecond);
          indexSecond--;
        }
      }
    }
    #endregion
  }
}