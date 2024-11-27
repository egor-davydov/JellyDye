using System;
using System.Collections.Generic;
using Code.Helpers;
using Code.Services.Progress;
using Code.StaticData;
using Code.StaticData.Level;
using Cysharp.Threading.Tasks;
using Fluxy;
using UnityEngine;
using UnityEngine.Rendering;
using Object = UnityEngine.Object;

namespace Code.Services
{
  public class PaintCountCalculationService
  {
    private const TextureFormat TextureFormat = UnityEngine.TextureFormat.RGBA32;

    private readonly StaticDataService _staticData;
    private readonly ProgressService _progress;

    private FluxySolver _fluxySolver;
    private FluxyContainer[] _fluxyContainers;

#if UNITY_EDITOR
    private readonly Dictionary<Color, int> _colors = new();
#endif
    private LevelConfig _currentLevelConfig;

    private Texture2D _densityReadbackTexture;
    private RenderTexture DensityRenderTexture => _fluxySolver.framebuffer.stateA;

    private PaintCountCalculationService(StaticDataService staticData, ProgressService progress)
    {
      _progress = progress;
      _staticData = staticData;
    }

    public void InitializeOnSceneLoad(FluxySolver fluxySolver, FluxyContainer[] fluxyContainers)
    {
      _fluxySolver = fluxySolver;
      _fluxyContainers = fluxyContainers;
      Object.Destroy(_densityReadbackTexture);
      _densityReadbackTexture = new Texture2D(DensityRenderTexture.width, DensityRenderTexture.height, TextureFormat, false);

      string currentLevelId = _progress.ForLevels.CurrentLevelId;
      _currentLevelConfig = _staticData.ForLevel(currentLevelId);
    }

    public bool HasPaintOnAllMeshes()
    {
      foreach (FluxyContainer fluxyContainer in _fluxyContainers)
      {
        if (!fluxyContainer.HasPaint)
          return false;
      }

      return true;
    }

    public async UniTask<float> CalculatePaintPercentageAsync()
    {
      await RequestDensityTextureAsync();
      int paintedPixelsCount = 0;
      int countPixelsShouldPaint = 0;
      foreach (FluxyContainer fluxyContainer in _fluxyContainers)
      {
        JellyMeshConfig jellyMeshConfig = _currentLevelConfig.GetConfigForMesh(fluxyContainer.customMesh);
        (int jellyPaintedPixelsCount, int jellyCountPixelsShouldPaint) = CalculateJellyPaintedPixelsCount(jellyMeshConfig, _fluxySolver.GetContainerUVRect(fluxyContainer));
        paintedPixelsCount += jellyPaintedPixelsCount;
        countPixelsShouldPaint += jellyCountPixelsShouldPaint;
      }

      float percentage = (float)paintedPixelsCount / countPixelsShouldPaint * 100;
      return percentage;
    }

    private (int, int) CalculateJellyPaintedPixelsCount(JellyMeshConfig jellyMeshConfig, Vector4 containerUVRect)
    {
      int paintedPixelsCount = 0;
      int shouldPaintedPixelsCount = jellyMeshConfig.Mesh.uv.Length;
      Texture2D maskTexture = jellyMeshConfig.MaskTexture;
      foreach (Vector2 uvCoordinates in jellyMeshConfig.Mesh.uv)
      {
        int maskX = (int)(uvCoordinates.x * maskTexture.width);
        int maskY = (int)(uvCoordinates.y * maskTexture.height);
        Color maskPixelColor = maskTexture.GetPixel(maskX, maskY);
        if (maskPixelColor.r != 0)
        {
          shouldPaintedPixelsCount--;
          continue;
        }

        float uvFluxyCoordinatesX = containerUVRect.x + uvCoordinates.x * containerUVRect.z;
        float uvFluxyCoordinatesY = containerUVRect.y + uvCoordinates.y * containerUVRect.w;
        int x = (int)(uvFluxyCoordinatesX * _densityReadbackTexture.width);
        int y = (int)(uvFluxyCoordinatesY * _densityReadbackTexture.height);
        Color pixelColor = _densityReadbackTexture.GetPixel(x, y).gamma;
        if (pixelColor != Color.clear)
        {
#if UNITY_EDITOR
          if (!_colors.ContainsKey(pixelColor))
            _colors.Add(pixelColor, 1);
          else
            _colors[pixelColor]++;
#endif

          if (MathHelp.VectorsSimilar(pixelColor, jellyMeshConfig.TargetColor, _staticData.ForLevels.ColorCompareEpsilon))
            paintedPixelsCount++;
        }
      }
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

      return (paintedPixelsCount, shouldPaintedPixelsCount);
    }

    private async UniTask RequestDensityTextureAsync()
    {
      AsyncGPUReadbackRequest request = await AsyncGPUReadback.Request(DensityRenderTexture, 0, TextureFormat);
      if (request.hasError)
        throw new Exception("GPU readback error.");

      _densityReadbackTexture.LoadRawTextureData(request.GetData<byte>());
      _densityReadbackTexture.Apply();
    }
  }
}