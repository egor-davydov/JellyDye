using System;
using System.Collections;
using Code.Gameplay.Logic;
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
    private Rect? _pixelsRegion;
    private LevelCamera _levelCamera;
    private RenderTexture _fullScreenRenderTexture;
    private int ScreenCenter => Screen.height / 2;

    public ScreenshotService(ICoroutineRunner coroutineRunner)
    {
      _coroutineRunner = coroutineRunner;
    }

    public void Initialize(Mesh mesh, Camera camera)
    {
      _deltaY = 0;
      _camera = camera;
      _platformBounds = mesh.bounds;
      _levelCamera = camera.GetComponent<LevelCamera>();
      _fullScreenRenderTexture = new RenderTexture(
        Screen.width, Screen.height, 0, RenderTextureFormat.Default, RenderTextureReadWrite.Default);
    }

    public void TakeScreenshot(Action<Texture2D> onTake)
    {
      _coroutineRunner.StartCoroutine(WaitRender(onTake));
    }

    public void TakeScreenshotWithoutGround(Action<Texture2D> onTake)
    {
      _coroutineRunner.StartCoroutine(WaitRenderWithoutGround(onTake));
    }

    private IEnumerator WaitRender(Action<Texture2D> onTake)
    {
      yield return new WaitForEndOfFrame();

      RenderTexture cameraTargetTexture = _camera.targetTexture;
      Texture2D screenshotTexture = TakeScreenshotFromCamera(_camera);
      _camera.targetTexture = cameraTargetTexture;
      onTake.Invoke(screenshotTexture);
    }

    private IEnumerator WaitRenderWithoutGround(Action<Texture2D> onTake)
    {
      yield return new WaitForEndOfFrame();
      
      Texture2D screenshotTexture = TakeScreenshotFromCamera(_levelCamera.ScreenshotCamera);
      onTake.Invoke(screenshotTexture);
    }

    private Texture2D TakeScreenshotFromCamera(Camera screenshotCamera)
    {
      screenshotCamera.targetTexture = _fullScreenRenderTexture;
      screenshotCamera.Render();
      RenderTexture.active = screenshotCamera.targetTexture;
      Texture2D screenshotTexture = ReadPixelsFromRegion();
      return screenshotTexture;
    }

    private Texture2D ReadPixelsFromRegion()
    {
      _pixelsRegion ??= CalculatePixelsRegion();
      Texture2D screenshotTexture = new Texture2D((int)_pixelsRegion.Value.width, (int)_pixelsRegion.Value.height, TextureFormat.RGB24, false);
      screenshotTexture.ReadPixels((Rect)_pixelsRegion, 0, 0);
      screenshotTexture.Apply();

      return screenshotTexture;
    }

    private Rect CalculatePixelsRegion()
    {
      Vector3 platformMax = _camera.WorldToScreenPoint(_platformBounds.max);
      Vector3 platformMin = _camera.WorldToScreenPoint(_platformBounds.min);
      platformMax.y -= _deltaY;
      // Debug.Log($"platformMax= {platformMax}");
      // Debug.Log($"platformMin= {platformMin}");
      int minX = Mathf.Clamp((int)platformMin.x, 0, Screen.width);
      int maxX = Mathf.Clamp((int)platformMax.x, 0, Screen.width);
      int minY = Mathf.Clamp((int)platformMin.y, 0, Screen.height);
      int maxY = Mathf.Clamp((int)platformMax.y, 0, Screen.height);
      maxX -= minX;
      // Debug.Log($"Screen.width={Screen.width}; Screen.height={Screen.height};");
      // Debug.Log($"minX={minX}; maxX={maxX}; minY={minY}; maxY={maxY}; ");
      Rect pixelsRegion = new(minX, minY - Screen.height/10, maxX, maxY+minY);
      return pixelsRegion;
    }
  }
}