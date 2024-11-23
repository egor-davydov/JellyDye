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
    private readonly StaticDataService _staticDataService;
    private readonly ProgressService _progressService;

    private FluxySolver _fluxySolver;
    private FluxyContainer[] _fluxyContainers;

#if UNITY_EDITOR
    private readonly Dictionary<Color, int> _colors = new();
#endif
    private LevelConfig _currentLevelConfig;

    private Texture2D _densityReadbackTexture;
    private RenderTexture DensityRenderTexture => _fluxySolver.framebuffer.stateA;

    private PaintCountCalculationService(StaticDataService staticDataService, ProgressService progressService)
    {
      _progressService = progressService;
      _staticDataService = staticDataService;
    }

    public void InitializeOnSceneLoad(FluxySolver fluxySolver, FluxyContainer[] fluxyContainers)
    {
      _fluxySolver = fluxySolver;
      _fluxyContainers = fluxyContainers;
      Object.Destroy(_densityReadbackTexture);
      _densityReadbackTexture = new Texture2D(DensityRenderTexture.width, DensityRenderTexture.height, TextureFormat.RGBAHalf, false);

      string currentLevelId = _progressService.Progress.LevelData.CurrentLevelId;
      _currentLevelConfig = _staticDataService.ForLevel(currentLevelId);
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
        float uvFluxyCoordinatesX = containerUVRect.x + uvCoordinates.x * containerUVRect.z;
        float uvFluxyCoordinatesY = containerUVRect.y + uvCoordinates.y * containerUVRect.w;
        int x = (int)(uvFluxyCoordinatesX * _densityReadbackTexture.width);
        int y = (int)(uvFluxyCoordinatesY * _densityReadbackTexture.height);
        if (maskTexture.GetPixel((int)(uvCoordinates.x * maskTexture.width), (int)(uvCoordinates.y * maskTexture.height)).r != 0)
        {
          shouldPaintedPixelsCount--;
          continue;
        }

        Color pixelColor = _densityReadbackTexture.GetPixel(x, y);
        if (pixelColor != Color.clear)
        {
#if UNITY_EDITOR
          if (!_colors.ContainsKey(pixelColor))
            _colors.Add(pixelColor, 1);
          else
            _colors[pixelColor]++;
#endif

          if (MathHelp.VectorsSimilar(pixelColor, jellyMeshConfig.TargetColor, _staticDataService.Levels.ColorCompareEpsilon))
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
      AsyncGPUReadbackRequest request = await AsyncGPUReadback.Request(DensityRenderTexture, 0, TextureFormat.RGBAHalf);
      if (request.hasError)
        throw new Exception("GPU readback error.");

      _densityReadbackTexture.LoadRawTextureData(request.GetData<float>());
      _densityReadbackTexture.Apply();
    }
  }
}