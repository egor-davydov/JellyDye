using System;
using System.Collections.Generic;
using System.Linq;
using Code.Helpers;
using UnityEngine;

namespace Code.StaticData.Level
{
  [Serializable]
  public class LevelConfig
  {
    public string Id;
    public List<JellyMeshConfig> JellyMeshConfigs;
    public GameObject JelliesPrefab;
    public List<Color> GetTargetColors => JellyMeshConfigs.Select(x => x.TargetColor).ToList();
    public List<Color> AdditionalColors;
    public List<Color> AllColors => GetTargetColors.Union(AdditionalColors).ToList();
    public Texture2D TargetTexture;
    public Texture2D TargetTextureWithGround;
    
    public void RemoveSimilarColorsByEpsilon( float epsilon)
    {
      List<Color> levelColors = AllColors;
      List<Color> targetColors = GetTargetColors;
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
  }
}