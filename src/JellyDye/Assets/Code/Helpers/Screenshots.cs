using System;
using System.Collections;
using System.IO;
using Code.Gameplay.Logic;
using Code.Gameplay.Syringe;
using Code.Gameplay.UI.Hud.PaintChange;
using Code.Services;
using Code.Services.Factories;
using Code.Services.Progress;
using Code.StaticData.Level;
using Fluxy;
using UnityEngine;
using Zenject;
using static Code.Constants.FolderPath;

namespace Code.Helpers
{
  public class Screenshots : MonoBehaviour
  {
#if UNITY_EDITOR
    private ProgressService _progressService;
    private StaticDataService _staticDataService;
    private ScreenshotService _screenshotService;
    private int _currentJellyCount;
    private JelliesFactory _jelliesFactory;
    private string _directionPath;
    private bool IsGroundActive => _groundObject.activeSelf;
    private GameObject _groundObject;
    private bool _groundScreenshotsDone;
    private Action _onDone;

    [Inject]
    public void Construct(ProgressService progressService, StaticDataService staticDataService,
      ScreenshotService screenshotService, JelliesFactory jelliesFactory)
    {
      _jelliesFactory = jelliesFactory;
      _screenshotService = screenshotService;
      _staticDataService = staticDataService;
      _progressService = progressService;
    }

    private void Awake()
    {
      _groundObject = GameObject.FindGameObjectWithTag("Ground");
      if(_groundObject == null)
        Debug.LogWarning("Couldn't find ground");
      
      _directionPath = $"{Application.dataPath}/Resources/{ResourcesScreenshotsPath}";
    }

    public void TakeScreenshots(bool withGround, Action onDone = null)
    {
      _groundObject.SetActive(withGround);
      _onDone = onDone;
      SetupAll();
      TakeScreenshot();
    }

    public void MoveCamera()
    {
      LevelCamera levelCamera = FindObjectOfType<LevelCamera>();
      levelCamera.Camera.orthographicSize = levelCamera.TargetSize;
      levelCamera.transform.eulerAngles = levelCamera.FinishRotation;
      levelCamera.transform.position = levelCamera.FinishPosition;
    }

    private void SetupAll()
    {
      MoveCamera();
      FindObjectOfType<ColorChangersContainer>()?.transform.parent.parent.parent.gameObject.SetActive(false);
      FindObjectOfType<SyringePaintColor>()?.gameObject.SetActive(false);
      _currentJellyCount = _staticDataService.ForLevels().GetLevelIndex(_progressService.Progress.LevelData.CurrentLevelId);
    }

    private void TakeScreenshot()
    {
      _screenshotService.TakeScreenshot(OnMake);
    }

    private void OnMake()
    {
      LevelConfig[] levelConfigs = _staticDataService.ForLevels().LevelConfigs;
      if (!Directory.Exists(_directionPath))
        Directory.CreateDirectory(_directionPath);

      WriteScreenshotOnDisk(levelConfigs);

      if (++_currentJellyCount < _staticDataService.ForLevels().LevelConfigs.Length)
      {
        Destroy(FindObjectOfType<FluxySolver>().transform.parent.gameObject);
        _jelliesFactory.CreateJelly(levelConfigs[_currentJellyCount].JelliesPrefab);
        StartCoroutine(WaitColorSet());
      }
      else
      {
        _onDone?.Invoke();
      }
    }

    private IEnumerator WaitColorSet()
    {
      yield return new WaitForEndOfFrame();
      yield return new WaitForEndOfFrame();
      TakeScreenshot();
    }

    private void WriteScreenshotOnDisk(LevelConfig[] levelConfigs)
    {
      string groundTag = IsGroundActive ? "_ground" : "";
      var screenshotPath = $"{_directionPath}/{levelConfigs[_currentJellyCount].Id}{groundTag}.png";
      byte[] bytes = _screenshotService.ScreenshotTexture.EncodeToPNG();
      if (File.Exists(screenshotPath))
        File.Delete(screenshotPath);
      File.WriteAllBytes(screenshotPath, bytes);
    }
  }
#endif
}