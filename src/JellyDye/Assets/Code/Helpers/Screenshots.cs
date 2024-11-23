using System;
using System.IO;
using Code.Gameplay.Logic;
using Code.Services;
using Code.Services.Factories;
using Code.Services.Progress;
using Code.Services.Providers;
using Cysharp.Threading.Tasks;
using Fluxy;
using UnityEngine;
using Zenject;
using static Code.Constants.FolderPath;

namespace Code.Helpers
{
  public class Screenshots : MonoBehaviour
  {
#if UNITY_EDITOR
    private ProgressService _progress;
    private StaticDataService _staticData;
    private ScreenshotService _screenshotService;
    private string _currentLevelId;
    private JelliesFactory _jelliesFactory;
    private string _directionPath;
    private bool IsGroundActive => _groundObject.activeSelf;
    private GameObject _groundObject;
    private bool _groundScreenshotsDone;
    private Action _onDone;
    private HudProvider _hudProvider;
    private SyringeProvider _syringeProvider;

    [Inject]
    public void Construct(ProgressService progressService, StaticDataService staticDataService,
      ScreenshotService screenshotService, JelliesFactory jelliesFactory, HudProvider hudProvider,
      SyringeProvider syringeProvider)
    {
      _syringeProvider = syringeProvider;
      _hudProvider = hudProvider;
      _jelliesFactory = jelliesFactory;
      _screenshotService = screenshotService;
      _staticData = staticDataService;
      _progress = progressService;
    }

    private void Awake()
    {
      _groundObject = GameObject.FindGameObjectWithTag("Ground");
      if (_groundObject == null)
        Debug.LogWarning("Couldn't find ground");

      _directionPath = $"{Application.dataPath}/Resources/{FromResourcesScreenshotsPath}";
      _currentLevelId = _progress.ForLevels.CurrentLevelId;
    }

    public async UniTask TakeScreenshots(bool withGround)
    {
      _groundObject.SetActive(withGround);
      SetupAll();
      if (!Directory.Exists(_directionPath))
        Directory.CreateDirectory(_directionPath);
      int startLevelIndex = _staticData.ForLevels.GetLevelIndex(_progress.ForLevels.CurrentLevelId);
      for (int i = startLevelIndex; i < _staticData.ForLevels.LevelConfigs.Length; i++)
      {
        string levelId = _staticData.ForLevels.LevelConfigs[i].Id;

        await ReplaceJellyBy(levelId);
        await UniTask.WaitForEndOfFrame();
        await UniTask.WaitForEndOfFrame();
        Texture2D screenshot = await _screenshotService.TakeScreenshotAsync();
        await WriteScreenshotOnDisk(screenshot, levelId);
      }

      await ReplaceJellyBy(_progress.ForLevels.CurrentLevelId);
    }

    public void MoveCamera()
    {
      LevelCamera levelCamera = FindAnyObjectByType<LevelCamera>();
      levelCamera.Camera.orthographicSize = levelCamera.TargetSize;
      levelCamera.transform.eulerAngles = levelCamera.FinishRotation;
      levelCamera.transform.position = levelCamera.FinishPosition;
    }

    private void SetupAll()
    {
      MoveCamera();
      _hudProvider.HudObject.SetActive(false);
      _syringeProvider.SyringeObject.SetActive(false);
    }

    private async UniTask ReplaceJellyBy(string id)
    {
      if (_currentLevelId == id)
        return;
      _currentLevelId = id;
      Destroy(FindAnyObjectByType<FluxySolver>().transform.parent.gameObject);
      await _jelliesFactory.CreateJelly(id);
    }

    private async UniTask WriteScreenshotOnDisk(Texture2D screenshot, string levelId)
    {
      string groundTag = IsGroundActive ? "_ground" : "";
      var screenshotPath = $"{_directionPath}/{levelId}{groundTag}.png";
      byte[] bytes = screenshot.EncodeToPNG();
      if (File.Exists(screenshotPath))
        File.Delete(screenshotPath);
      await File.WriteAllBytesAsync(screenshotPath, bytes);
    }
#endif
  }
}