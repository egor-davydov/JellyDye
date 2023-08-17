using System;
using UnityEngine;

namespace Code.StaticData
{
  [Serializable]
  public class LevelConfig
  {
    public GameObject JelliesPrefab;
    public Color[] Colors;
    public Texture2D TargetTexture;
    public Texture2D TargetTextureWithGround;
  }
}