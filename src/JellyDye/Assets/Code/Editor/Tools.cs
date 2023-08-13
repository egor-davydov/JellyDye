using System.Collections;
using System.IO;
using System.Linq;
using Code.Gameplay.Hud.PaintChange;
using Code.Gameplay.Logic;
using Code.Gameplay.Syringe;
using Code.Services;
using Code.Services.Progress;
using Code.Services.Progress.SaveLoad;
using Code.StaticData;
using UnityEditor;
using UnityEngine;

namespace Code.Editor
{
  public static class Tools
  {
    private static ScreenshotService _screenshotService;
    private static ProgressService _progressService;
    private static StaticDataService _staticDataService;

    [MenuItem("Tools/Delete Progress file")]
    public static void ClearProgress()
    {
      File.Delete(FileSaveLoadService.ProgressFilePath);
    }
    [MenuItem("Tools/Take Screenshot")]
    public static void TakeScreenshot()
    {
      if (!Application.isPlaying)
        return;
      LevelCamera levelCamera = Object.FindObjectOfType<LevelCamera>();
      ColorChangersContainer colorChangersContainer = Object.FindObjectOfType<ColorChangersContainer>();
      colorChangersContainer.transform.parent.parent.parent.gameObject.SetActive(false);
      Object.FindObjectOfType<SyringePaint>().gameObject.SetActive(false);
      levelCamera.transform.eulerAngles = levelCamera.FinishRotation;
      levelCamera.transform.position = levelCamera.FinishPosition;
      levelCamera.GetComponent<Camera>().orthographicSize = levelCamera.TargetSize;
      _staticDataService = new StaticDataService();
      _progressService = new();
      FileSaveLoadService fileSaveLoadService = new(_progressService);
      _progressService.SetProgress(fileSaveLoadService.LoadProgress());
      _staticDataService.Initialize();
      _screenshotService = new ScreenshotService(levelCamera);
      _screenshotService.Initialize();
      _screenshotService.TakeScreenshot();
      levelCamera.StartCoroutine(WaitScreenshot());
    }

    private static IEnumerator WaitScreenshot()
    {
      while (_screenshotService.IsScreenshotCaptured == false)
        yield return null;

      Texture2D screenshotTexture = _screenshotService.ScreenshotTexture;
      byte[] bytes = screenshotTexture.EncodeToPNG();
      LevelConfig levelConfig = _staticDataService.ForLevels().LevelConfigs[_progressService.Progress.CurrentLevel];
      string directionPath = $"{Application.dataPath}/Resources/Levels/TargetColorScreenshots";
      if (!Directory.Exists(directionPath))
        Directory.CreateDirectory(directionPath);
      var screenshotPath = $"{directionPath}/{levelConfig.JelliesPrefab.name}.png";
      if (File.Exists(screenshotPath))
        File.Delete(screenshotPath);
      File.WriteAllBytes(screenshotPath, bytes); 
    }
  }
}