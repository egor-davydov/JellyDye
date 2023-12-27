using System;
using System.Collections;
using Code.Infrastructure;
using UnityEngine;

namespace Code.Services
{
  public class ScreenshotService
  {
    private readonly ICoroutineRunner _coroutineRunner;
    private Bounds _platformBounds;
    private Camera _camera;
    private int _deltaY;
    private int ScreenCenter => Screen.height/2;

    public Texture2D ScreenshotTexture { get; private set; }

    public ScreenshotService(ICoroutineRunner coroutineRunner)
    {
      _coroutineRunner = coroutineRunner;
    }
    public void Initialize(Mesh mesh, Camera camera)
    {
      _deltaY = 30;
      _camera = camera;
      _platformBounds = mesh.bounds;
      ScreenshotTexture = new Texture2D(Screen.width, Screen.height, TextureFormat.RGB24, false);
    }

    public void TakeScreenshot(Action onTake)
    {
      _coroutineRunner.StartCoroutine(WaitRender(onTake));
    }

    private IEnumerator WaitRender(Action onTake)
    {
      yield return new WaitForEndOfFrame();
      SetPixelsFromRegion();
      onTake.Invoke();
    }

    private void SetPixelsFromRegion()
    {
      Rect pixelsRegion = CalculatePixelsRegion();
      ScreenshotTexture.ReadPixels(pixelsRegion, 0, 0, false);
      ScreenshotTexture.Apply();
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
      ScreenshotTexture = new Texture2D(maxX, maxY+minY, TextureFormat.RGB24, false);
      Rect pixelsRegion = new(minX, minY, maxX, maxY+minY);
      return pixelsRegion;
    }
  }
}