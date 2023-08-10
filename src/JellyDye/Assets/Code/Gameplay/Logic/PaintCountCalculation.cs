using System;
using System.Linq;
using Code.Services;
using Code.StaticData;
using Fluxy;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Code.Gameplay.Logic
{
  public class PaintCountCalculation : MonoBehaviour
  {
    [SerializeField] private Button _calculateButton;
    [SerializeField] private RawImage _textureImage;
    [SerializeField] private RawImage _textureImage2;
    [SerializeField] private TextMeshProUGUI _percentageText;

    private FluxySolver _fluxySolver;
    private StaticDataService _staticDataService;
    private FluxyContainer[] _fluxyContainers;

    [Inject]
    public void Construct(StaticDataService staticDataService)
    {
      _staticDataService = staticDataService;
    }

    public void Initialize(FluxyContainer[] fluxyContainers)
    {
      _fluxyContainers = fluxyContainers;
    }

    private void Awake()
    {
      _calculateButton.onClick.AddListener(CalculatePaintCount);
    }

    private void Update()
    {
      if (_fluxySolver == null)
      {
        _fluxySolver = FindObjectOfType<FluxySolver>();
        if (_fluxySolver == null)
          return;
        Initialize(FindObjectsOfType<FluxyContainer>());
        // foreach (FluxyContainer fluxyContainer in FindObjectsOfType<FluxyContainer>())
        // {
        //   Debug.Log($"fluxyContainer.customMesh.name= {fluxyContainer.customMesh.name}; _fluxySolver.GetContainerUVRect= {_fluxySolver.GetContainerUVRect(fluxyContainer)}");
        // }
      }

      _textureImage.texture = _fluxySolver.framebuffer.stateA;
    }

    private void CalculatePaintCount()
    {
      Texture2D fluxyTexture = ConvertToTexture2D(_fluxySolver.framebuffer.stateA);
      int paintedPixelsCount = 0;
      int countPixelsShouldPaint = 0;
      foreach (FluxyContainer fluxyContainer in _fluxyContainers)
      {
        JellyConfig jellyConfig = _staticDataService.ForJellies().JellyConfigs.First(config => config.Mesh == fluxyContainer.customMesh);
        paintedPixelsCount += CalculateJellyPaintedPixelsCount(fluxyTexture, jellyConfig.MaskTexture, _fluxySolver.GetContainerUVRect(fluxyContainer));
        countPixelsShouldPaint += jellyConfig.CountPixelsShouldPaint;
      }

      _percentageText.text = ((float)paintedPixelsCount / countPixelsShouldPaint * 100).ToString();
    }

    private int CalculateJellyPaintedPixelsCount(Texture2D fluxyTexture, Texture2D maskTexture, Vector4 containerUVRect)
    {
      int paintedPixelsCount = 0;
      int textureStartX = (int)(fluxyTexture.width * containerUVRect.x);
      int textureStartY = (int)(fluxyTexture.height * containerUVRect.y);
      int textureSizeX = (int)(fluxyTexture.width * containerUVRect.z);
      int textureSizeY = (int)(fluxyTexture.height * containerUVRect.w);
      for (int x = textureStartX; x < textureStartX + textureSizeX; x++)
      for (int y = textureStartY; y < textureStartY + textureSizeY; y++)
      {
        int maskTextureX = (x - textureStartX) * (maskTexture.width / textureSizeX);
        int maskTextureY = (y - textureStartY) * (maskTexture.height / textureSizeY);
        if (maskTexture.GetPixel(maskTextureX, maskTextureY).r != 0)
          continue;
        Color pixelColor = fluxyTexture.GetPixel(x, y);
        if (pixelColor.b > 0)
          paintedPixelsCount++;
      }
      Debug.Log($"mesh= {maskTexture.name}; paintedPixelsCount= {paintedPixelsCount}");
      return paintedPixelsCount;
    }

    private Texture2D ConvertToTexture2D(RenderTexture rTex)
    {
      Texture2D tex = new Texture2D(512, 512, TextureFormat.RGBA32, false);
      RenderTexture.active = rTex;
      tex.ReadPixels(new Rect(0, 0, rTex.width, rTex.height), 0, 0);
      tex.Apply();
      return tex;
    }
  }
}