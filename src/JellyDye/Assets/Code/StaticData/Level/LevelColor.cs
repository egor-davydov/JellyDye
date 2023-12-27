using System;
using UnityEngine;

namespace Code.StaticData.Level
{
  [Serializable]
  public class LevelColor
  {
    [field: SerializeField] public Color Color { get; private set; }
    [field: SerializeField] public bool IsTargetColor { get; private set; }

    public LevelColor(Color color, bool isTargetColor)
    {
      Color = color;
      IsTargetColor = isTargetColor;
    }
  }
}