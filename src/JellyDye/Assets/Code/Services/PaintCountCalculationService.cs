using System.Collections.Generic;
using System.Linq;
using Code.Helpers;
using Code.Services.Progress;
using Code.StaticData;
using Fluxy;
using UnityEngine;

namespace Code.Services
{
  public class PaintCountCalculationService
  {
    private readonly StaticDataService _staticDataService;
    private readonly ProgressService _progressService;
    
    private FluxySolver _fluxySolver;
    private FluxyContainer[] _fluxyContainers;

#if UNITY_EDITOR
    private readonly Dictionary<Color, int> _colors = new();
#endif
    private Rect _convertToTextureRect;
    private RenderTexture _fluxyStateA;
    private List<JellyMeshConfig> _currentLevelJellyMeshConfigs;
    

    private PaintCountCalculationService(StaticDataService staticDataService, ProgressService progressService)
    {
      _progressService = progressService;
      _staticDataService = staticDataService;
    }

    public void InitializeOnSceneLoad(FluxySolver fluxySolver, FluxyContainer[] fluxyContainers)
    {
      _fluxySolver = fluxySolver;
      _fluxyContainers = fluxyContainers;
      _fluxyStateA = _fluxySolver.framebuffer.stateA;
      _convertToTextureRect = new Rect(0, 0, _fluxyStateA.width, _fluxyStateA.height);
      
      string currentLevelId = _progressService.Progress.LevelData.CurrentLevelId;
      _currentLevelJellyMeshConfigs = _staticDataService.ForLevels().GetConfigByLevelId(currentLevelId).JellyMeshConfigs;
    }

    public bool HasPaintOnAllMeshes()
    {
      Texture2D fluxyTexture = ConvertToTexture2D();
      foreach (FluxyContainer fluxyContainer in _fluxyContainers)
      {
        JellyMeshConfig jellyMeshConfig = _currentLevelJellyMeshConfigs.First(config => config.Mesh == fluxyContainer.customMesh);
        if (!HasPaintOnMesh(fluxyTexture, jellyMeshConfig, _fluxySolver.GetContainerUVRect(fluxyContainer)))
        {
          Object.Destroy(fluxyTexture);
          return false;
        }
      }
      Object.Destroy(fluxyTexture);

      return true;
    }

    private bool HasPaintOnMesh(Texture2D fluxyTexture, JellyMeshConfig jellyMeshConfig, Vector4 containerUVRect)
    {
      Texture2D maskTexture = jellyMeshConfig.MaskTexture;

      foreach (Vector2 uvCoordinates in jellyMeshConfig.Mesh.uv)
      {
        float uvCoordinatesX = containerUVRect.x + uvCoordinates.x * containerUVRect.z;
        float uvCoordinatesY = containerUVRect.y + uvCoordinates.y * containerUVRect.w;
        int x = (int)(uvCoordinatesX * fluxyTexture.width);
        int y = (int)(uvCoordinatesY * fluxyTexture.height);
        if (maskTexture.GetPixel((int)(uvCoordinates.x * maskTexture.width), (int)(uvCoordinates.y * maskTexture.height)).r != 0)
          continue;

        Color pixelColor = fluxyTexture.GetPixel(x, y);
        if (pixelColor != Color.clear)
        {
          Object.Destroy(fluxyTexture);
          return true;
        }
      }
      Object.Destroy(fluxyTexture);

      return false;
    }

    public float CalculatePaintPercentage()
    {
      Texture2D fluxyTexture = ConvertToTexture2D();
      int paintedPixelsCount = 0;
      int countPixelsShouldPaint = 0;
      foreach (FluxyContainer fluxyContainer in _fluxyContainers)
      {
        JellyMeshConfig jellyMeshConfig = _currentLevelJellyMeshConfigs.First(config => config.Mesh == fluxyContainer.customMesh);
        Vector2Int pixelsCount = CalculateJellyPaintedPixelsCount(fluxyTexture, jellyMeshConfig, _fluxySolver.GetContainerUVRect(fluxyContainer));
        paintedPixelsCount += pixelsCount.x;
        countPixelsShouldPaint += pixelsCount.y;
      }
      Object.Destroy(fluxyTexture);

      return (float)paintedPixelsCount / countPixelsShouldPaint * 100;
    }

    private Vector2Int CalculateJellyPaintedPixelsCount(Texture2D fluxyTexture, JellyMeshConfig jellyMeshConfig, Vector4 containerUVRect)
    {
      int paintedPixelsCount = 0;
      int shouldPaintedPixelsCount = jellyMeshConfig.Mesh.uv.Length;
      Texture2D maskTexture = jellyMeshConfig.MaskTexture;
      foreach (Vector2 uvCoordinates in jellyMeshConfig.Mesh.uv)
      {
        float uvFluxyCoordinatesX = containerUVRect.x + uvCoordinates.x * containerUVRect.z;
        float uvFluxyCoordinatesY = containerUVRect.y + uvCoordinates.y * containerUVRect.w;
        int x = (int)(uvFluxyCoordinatesX * fluxyTexture.width);
        int y = (int)(uvFluxyCoordinatesY * fluxyTexture.height);
        if (maskTexture.GetPixel((int)(uvCoordinates.x * maskTexture.width), (int)(uvCoordinates.y * maskTexture.height)).r != 0)
        {
          shouldPaintedPixelsCount--;
          continue;
        }

        Color pixelColor = fluxyTexture.GetPixel(x, y);
        if (pixelColor != Color.clear)
        {
#if UNITY_EDITOR
          if (!_colors.ContainsKey(pixelColor))
            _colors.Add(pixelColor, 1);
          else
            _colors[pixelColor]++;
#endif
          // if (jellyMeshConfig.Mesh.name == "topM")
          //   Debug.Log($"pixelColor= {pixelColor}");
          if (MathHelp.VectorsSimilar(pixelColor, jellyMeshConfig.TargetColor, _staticDataService.ForLevels().ColorCompareEpsilon))
            paintedPixelsCount++;
        }
      }
      Object.Destroy(fluxyTexture);
#if UNITY_EDITOR
      int maxColorsCount = 0;
      Color maxColorsCountColor = Color.clear;
      foreach (KeyValuePair<Color, int> keyValuePair in _colors)
      {
        if (keyValuePair.Value > 100)
          Debug.Log($"color={keyValuePair.Key};count={keyValuePair.Value};");
        if (keyValuePair.Value > maxColorsCount)
        {
          maxColorsCount = keyValuePair.Value;
          maxColorsCountColor = keyValuePair.Key;
        }
      }
      _colors.Clear();

      Debug.Log($"name={jellyMeshConfig.Mesh.name}; percentage= {(float)paintedPixelsCount / shouldPaintedPixelsCount * 100}; painted={paintedPixelsCount};shouldPainted={shouldPaintedPixelsCount};");
      Debug.Log($"maxColorsCountColor={maxColorsCountColor};TargetColor={jellyMeshConfig.TargetColor}; maxColorsCount= {maxColorsCount};");
#endif

      return new Vector2Int(paintedPixelsCount, shouldPaintedPixelsCount);
    }


    private Texture2D ConvertToTexture2D()
    {
      RenderTexture oldTexture = RenderTexture.active;
      Texture2D texture2D = new Texture2D(_fluxyStateA.width, _fluxyStateA.height, TextureFormat.RGBA32, false);
      RenderTexture.active = _fluxyStateA;
      texture2D.ReadPixels(_convertToTextureRect, 0, 0);
      texture2D.Apply();
      RenderTexture.active = oldTexture;

      return texture2D;
    }
  }
}