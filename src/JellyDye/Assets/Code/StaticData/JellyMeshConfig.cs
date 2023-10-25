using System;
using UnityEngine;

namespace Code.StaticData
{
  [Serializable]
  public class JellyMeshConfig
  {
    [field: SerializeField] public Mesh Mesh { get; private set; }
    [field: SerializeField] public Texture2D MaskTexture { get; private set; }
    [field: SerializeField] public Color TargetColor { get; private set; }

    public JellyMeshConfig(Mesh mesh, Color targetColor)
    {
      Mesh = mesh;
      TargetColor = targetColor;
    }

    public void SetMask(Texture2D maskTexture) => 
      MaskTexture = maskTexture;
  }
}