using System;
using System.Collections;
using Code.Infrastructure;
using Cysharp.Threading.Tasks;
using UnityEngine;

namespace Code.Services
{
  public class ScreenshotService
  {
    private Bounds _platformBounds;
    private Camera _camera;
    private int _deltaY;
    private int ScreenCenter => Screen.height/2;

    public void Initialize(Mesh mesh, Camera camera)
    {
      _deltaY = 30;
      _camera = camera;
      _platformBounds = mesh.bounds;
    }

    public async UniTask<Texture2D> TakeScreenshot()
    {
      await UniTask.WaitForEndOfFrame();
      Texture2D screenshotTexture = ScreenshotFromRegion();
      return screenshotTexture;
    }
    
    private Texture2D ScreenshotFromRegion()
    {
      Rect pixelsRegion = CalculatePixelsRegion();
      var screenshotTexture = new Texture2D((int)pixelsRegion.width, (int)pixelsRegion.height, TextureFormat.RGB24, false);
      screenshotTexture.ReadPixels(pixelsRegion, 0, 0, false);
      screenshotTexture.Apply();
      return screenshotTexture;
    }

    private Rect CalculatePixelsRegion()
    {
      Vector3 platformMax = _camera.WorldToScreenPoint(_platformBounds.max);
      Vector3 platformMin = _camera.WorldToScreenPoint(_platformBounds.min);
      platformMax.y -= _deltaY;
      int minX = Mathf.Clamp((int)platformMin.x, 0, Screen.width);
      int maxX = Mathf.Clamp((int)platformMax.x, 0, Screen.width);
      int minY = Mathf.Clamp((int)platformMin.y, 0, Screen.height);
      int maxY = Mathf.Clamp((int)platformMax.y, 0, Screen.height);
      maxX -= minX;
#if UNITY_EDITOR
      // Debug.Log($"platformMax= {platformMax}");
      // Debug.Log($"platformMin= {platformMin}");
      // Debug.Log($"Screen.width={Screen.width}; Screen.height={Screen.height};");
      // Debug.Log($"minX={minX}; maxX={maxX}; minY={minY}; maxY={maxY}; ");
#endif
      Rect pixelsRegion = new(minX, minY, maxX, maxY+minY);
      return pixelsRegion;
    }
  }
}