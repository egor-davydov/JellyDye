using System.Collections;
using Code.Infrastructure;
using UnityEngine;
using Zenject;

namespace Code.Services
{
  public class ScreenshotService : IInitializable
  {
    private readonly ICoroutineRunner _coroutineRunner;
    
    public Texture2D ScreenshotTexture { get; private set; }
    public bool IsScreenshotCaptured { get; private set; }

    public ScreenshotService(ICoroutineRunner coroutineRunner)
    {
      _coroutineRunner = coroutineRunner;
    }
    public void Initialize()
    {
      ScreenshotTexture = new Texture2D(Screen.width, Screen.height, TextureFormat.RGB24, false);
    }

    public void TakeScreenshot()
    {
      IsScreenshotCaptured = false;
      _coroutineRunner.StartCoroutine(Coroutine());
    }

    private IEnumerator Coroutine()
    {
      yield return new WaitForEndOfFrame();
      SetPixelsFromRegion();
      IsScreenshotCaptured = true;
    }

    private void SetPixelsFromRegion()
    {
      Rect pixelsRegion = new(0, 0, Screen.width, Screen.height);
      ScreenshotTexture.ReadPixels(pixelsRegion, 0, 0, false);
      ScreenshotTexture.Apply();
    }
  }
}