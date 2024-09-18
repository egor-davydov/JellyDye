using System;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace Code.StaticData
{
  [Serializable]
  public class JellyMeshConfig
  {
    [field: SerializeField] public AssetReference MeshReference { get; private set; }
    [field: SerializeField] public Texture2D MaskTexture { get; private set; }
    [field: SerializeField] public Color TargetColor { get; private set; }

    private Mesh _mesh;
    
    public Mesh Mesh
    {
      get => _mesh;
      set => _mesh = value;
    }

    public JellyMeshConfig(Mesh mesh, Color targetColor)
    {
      Mesh = mesh;
      TargetColor = targetColor;
    }

    public void SetTargetColorAlphaToOne()
    {
      Color tempColor = TargetColor;
      tempColor.a = 1;
      TargetColor = tempColor;
    }

    public void SetMeshReference(AssetReference meshReference) => 
      MeshReference = meshReference;

    public void SetMask(Texture2D maskTexture) => 
      MaskTexture = maskTexture;
  }
}