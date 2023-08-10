using System;
using UnityEngine;

namespace Code.StaticData
{
  [Serializable]
  public class JellyConfig
  {
    public Mesh Mesh;
    public Texture2D MaskTexture;
    public int CountPixelsShouldPaint;
    public Color TargetColor;
  }
}