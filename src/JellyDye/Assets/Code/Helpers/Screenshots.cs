using System.Collections;
using System.IO;
using System.Linq;
using Code.Gameplay.Logic;
using Code.Gameplay.Syringe;
using Code.Gameplay.UI.Hud.PaintChange;
using Code.Services;
using Code.Services.Factories;
using Code.Services.Progress;
using Code.StaticData;
using UnityEngine;
using Zenject;

namespace Code.Helpers
{
  public class Screenshots : MonoBehaviour
  {
    private ProgressService _progressService;
    private StaticDataService _staticDataService;
    private ScreenshotService _screenshotService;
    private int _currentJellyCount;
    private JelliesFactory _jelliesFactory;
    private int _levelsCount;
    private string _directionPath;
    private bool _withGround;
    private string _screenshotsFolder;

    [Inject]
    public void Construct( ProgressService progressService,
      StaticDataService staticDataService, ScreenshotService screenshotService, JelliesFactory jelliesFactory)
    {
      _jelliesFactory = jelliesFactory;
      _screenshotService = screenshotService;
      _staticDataService = staticDataService;
      _progressService = progressService;
    }

    private void Awake()
    {
      _screenshotsFolder = "Levels/TargetColorScreenshots";
      _directionPath = $"{Application.dataPath}/Resources/{_screenshotsFolder}";
      string[] files = Directory.GetFiles($"{Application.dataPath}/Resources/Levels/Jellies", "*.prefab");
      _levelsCount = files.Length - 2;
      //Debug.Log($"_levelsCount= {_levelsCount} firstFile= {files[0]}");
    }

    public void SetupAllScreenshots()
    {
      Texture2D[] texture2Ds = Resources.LoadAll<Texture2D>(_screenshotsFolder);
      if(texture2Ds.Length == 0)
      {
        Debug.LogError("Cant find screenshot textures");
        return;
      }
      foreach (LevelConfig levelConfig in _staticDataService.ForLevels().LevelConfigs)
      {
        Debug.Log("Setup " + levelConfig.JelliesPrefab.name);
        levelConfig.TargetTexture = texture2Ds.First(texture2D => texture2D.name == levelConfig.JelliesPrefab.name);
        levelConfig.TargetTextureWithGround = texture2Ds.First(texture2D => texture2D.name == levelConfig.JelliesPrefab.name + "_ground");
      }
    }

    public void TakeScreenshots()
    {
      _withGround = true;
      Setup();
      TakeScreenshot();
    }

    public void TakeScreenshotsWithoutGround()
    {
      _withGround = false;
      GameObject.FindGameObjectWithTag("Ground")?.SetActive(false);
      Setup();
      TakeScreenshot();
    }

    public void MoveCamera()
    {
      LevelCamera levelCamera = FindObjectOfType<LevelCamera>();
      levelCamera.Camera.orthographicSize = levelCamera.TargetSize;
      levelCamera.transform.eulerAngles = levelCamera.FinishRotation;
      levelCamera.transform.position = levelCamera.FinishPosition;
    }

    private void Setup()
    {
      MoveCamera();
      FindObjectOfType<ColorChangersContainer>()?.transform.parent.parent.parent.gameObject.SetActive(false);
      FindObjectOfType<SyringePaint>()?.gameObject.SetActive(false);
      _currentJellyCount = _progressService.Progress.LevelData.CurrentLevelIndex;
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

      if (++_currentJellyCount < _levelsCount)
      {
        Destroy(FindObjectOfType<JellyAutoConstruct>().gameObject);
        GameObject jelly = _jelliesFactory.CreateJelly(levelConfigs[_currentJellyCount].JelliesPrefab);
        StartCoroutine(WaitColorSet(jelly.GetComponentInChildren<SetTargetColorFromClearColor>()));
      }
    }

    private IEnumerator WaitColorSet(SetTargetColorFromClearColor setTargetColorFromClearColor)
    {
      yield return new WaitForEndOfFrame();
      TakeScreenshot();
    }

    private void WriteScreenshotOnDisk(LevelConfig[] levelConfigs)
    {
      byte[] bytes = _screenshotService.ScreenshotTexture.EncodeToPNG();
      string groundTag = _withGround ? "_ground" : "";
      var screenshotPath = $"{_directionPath}/{levelConfigs[_currentJellyCount].JelliesPrefab.name}{groundTag}.png";
      if (File.Exists(screenshotPath))
        File.Delete(screenshotPath);
      File.WriteAllBytes(screenshotPath, bytes);
    }
  }
}