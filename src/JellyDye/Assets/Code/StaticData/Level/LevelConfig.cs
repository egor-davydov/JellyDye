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
    //public List<Color> GetTargetColors => AdditionalColors.Where(x=>x.IsTargetColor).Select(x => x.Color).ToList();
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
        // if (targetColors.Contains(firstColor) && targetColors.Contains(secondColor))
        // {
        //   if (MathHelp.VectorsSimilar(firstColor, secondColor, epsilon))
        //     Debug.LogWarning($"Target colors of level \"{Id}\" is similar\nfirst=({firstColor}, index={indexFirst}); second=({secondColor}, index={indexSecond})");
        //   continue;
        // }
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

    // public void RemoveSimilarColorsByEpsilon( float epsilon)
    // {
    //   List<LevelColor> levelColors = AdditionalColors;
    //   //List<Color> targetColors = GetTargetColors;
    //   for (int indexFirst = 0; indexFirst < levelColors.Count; indexFirst++)
    //   for (int indexSecond = indexFirst + 1; indexSecond < levelColors.Count; indexSecond++)
    //   {
    //     LevelColor firstLevelColor = levelColors[indexFirst];
    //     LevelColor secondLevelColor = levelColors[indexSecond];
    //     Color firstColor = firstLevelColor.Color;
    //     Color secondColor = secondLevelColor.Color;
    //     // if (targetColors.Contains(firstColor) && targetColors.Contains(secondColor))
    //     // {
    //     //   if (MathHelp.VectorsSimilar(firstColor, secondColor, epsilon))
    //     //     Debug.LogWarning($"Target colors of level \"{Id}\" is similar\nfirst=({firstColor}, index={indexFirst}); second=({secondColor}, index={indexSecond})");
    //     //   continue;
    //     // }
    //     if (MathHelp.VectorsSimilar(firstColor, secondColor, epsilon))
    //     {
    //       bool isFirstTargetColor = firstLevelColor.IsTargetColor;
    //       bool isSecondTargetColor = secondLevelColor.IsTargetColor;
    //       if (isFirstTargetColor && isSecondTargetColor)
    //         continue;
    //       if(epsilon > 0.3f)
    //         Debug.LogWarning($"Removing similar color in level \"{Id}\"\n firstColor=({firstColor}, index={indexFirst});secondColor=({secondColor}, index={indexSecond}); ");
    //       if (!isFirstTargetColor)
    //       {
    //         levelColors.RemoveAt(indexFirst);
    //         indexSecond--;
    //         continue;
    //       }
    //
    //       levelColors.RemoveAt(indexSecond);
    //       indexSecond--;
    //     }
    //   }
    // }

  }
}