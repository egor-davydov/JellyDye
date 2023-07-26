using System;
using UnityEngine;
using UnityEngine.UI;

public class PaintTextureTestView : MonoBehaviour
{
  [SerializeField] private SkinnedMeshRenderer _paintRenderer;
  private static readonly int MainTex = Shader.PropertyToID("_MainTex");
  private RawImage _rawImage;

  private void Awake()
  {
    _rawImage = GetComponent<RawImage>();
  }

  private void Update()
  {
    Texture rawImageTexture = _paintRenderer.material.GetTexture(MainTex);
    _rawImage.texture = rawImageTexture;
  }
}