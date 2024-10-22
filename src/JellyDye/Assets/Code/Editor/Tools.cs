using System;
using System.IO;
using Code.Constants;
using Code.Data;
using Code.Gameplay.UI.MainMenu.Skins;
using Code.Helpers;
using Code.Services;
using Code.Services.Progress;
using Code.Services.Progress.SaveLoad;
using Code.StaticData.Level;
using Fluxy;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;
using Object = UnityEngine.Object;

namespace Code.Editor
{
  public static class Tools
  {
    public static readonly string AbsoluteJelliesToAddPath = $"{FolderPath.ResourcesPath}/JelliesToAdd";
    public static readonly string AbsoluteHelpersPath = "Assets/SceneAssets/Helpers.prefab";
    public static readonly string AbsoluteTargetToFillContainerWithPaintPath = "Assets/SceneAssets/TargetToFillContainerWithPaint.prefab";
    private const string ToolsPath = "Tools/Custom/";
    private const string Progress = "Progress/";
    private const string Screenshots = "Take screenshots/";
    private const string Other = "Other/";

    private static Screenshots ScreenshotsHelper => Object.FindAnyObjectByType<Screenshots>();

    [MenuItem(ToolsPath + Progress + "Delete Progress file")]
    public static void ClearProgress() =>
      File.Delete(FilePath.ProgressPath);

    [MenuItem(ToolsPath + Progress + "Make game full completed")]
    public static void CompleteProgressData()
    {
      var staticDataService = new StaticDataService();
      staticDataService.Initialize();
      var progressService = new ProgressService(staticDataService);
      PlayerProgress playerProgress = progressService.NewProgress();
      foreach (LevelConfig levelConfig in staticDataService.ForLevels().LevelConfigs)
        playerProgress.LevelData.ManageCompletedLevel(levelConfig.Id, 100);
      foreach (SkinType skinType in Enum.GetValues(typeof(SkinType)))
        playerProgress.SkinData.OpenedSkins.Add(skinType);
      progressService.SetProgress(playerProgress);
      ISaveLoadService saveLoadService = new FileSyncSaveLoadService(progressService);
      saveLoadService.SaveProgress();
    }

    [MenuItem(ToolsPath + "Delete files in \"_JelliesToAdd\" folder, that ends with \"d1\"")]
    public static void DeleteFiles()
    {
      string[] files = Directory.GetFiles(AbsoluteJelliesToAddPath);
      foreach (string file in files)
      {
        string[] strings = file.Split('.');
        if (strings[0].EndsWith("d1"))
          File.Delete(file);
      }

      AssetDatabase.SaveAssets();
      AssetDatabase.Refresh();
    }

    [MenuItem(ToolsPath + Screenshots + "All")]
    public static async void TakeScreenshots()
    {
      if (NotInPlayModeShowError())
        return;

      await ScreenshotsHelper.TakeScreenshots(withGround: true);
      TakeScreenshotsWithoutGround();
    }

    [MenuItem(ToolsPath + Screenshots + "With ground")]
    public static async void TakeScreenshotsWithGround()
    {
      if (NotInPlayModeShowError())
        return;

      await ScreenshotsHelper.TakeScreenshots(withGround: true);
      RefreshAssets();
    }

    [MenuItem(ToolsPath + Screenshots + "Without ground")]
    public static async void TakeScreenshotsWithoutGround()
    {
      if (NotInPlayModeShowError())
        return;

      await ScreenshotsHelper.TakeScreenshots(withGround: false);
      RefreshAssets();
    }

    [MenuItem(ToolsPath + Other + "Setup game for taking screenshots")]
    public static void SetupForScreenshots()
    {
      GameObject helpersPrefab = AssetDatabase.LoadAssetAtPath<GameObject>(AbsoluteHelpersPath);
      if (ScreenshotsHelper == null)
        PrefabUtility.InstantiatePrefab(helpersPrefab);
      GameObject targetPrefab = AssetDatabase.LoadAssetAtPath<GameObject>(AbsoluteTargetToFillContainerWithPaintPath);
      GameObject softbodyPrefab = Resources.Load<GameObject>($"{FolderPath.FromResourcesJelliesPath}/{AssetName.SoftbodySolver}");
      GameObject softbodyPrefabContents = PrefabUtility.LoadPrefabContents(AssetDatabase.GetAssetPath(softbodyPrefab));
      FluxyContainer fluxyContainer = softbodyPrefabContents.GetComponentInChildren<FluxyContainer>();

      bool isAlreadySetup = fluxyContainer.UseMeshProjection == false;
      if (isAlreadySetup)
      {
        fluxyContainer.UseMeshProjection = false;

        fluxyContainer.gameObject.AddComponent<AutoSetTargetColor>();

        GameObject targetObject = (GameObject)PrefabUtility.InstantiatePrefab(targetPrefab, fluxyContainer.transform);
        targetObject.transform.position = Vector3.zero;

        fluxyContainer.targets.Add(targetObject.GetComponent<FluxyTarget>());

        PrefabUtility.SaveAsPrefabAsset(softbodyPrefabContents, AssetDatabase.GetAssetPath(softbodyPrefab));
        SetDirtyCurrentScene();
      }
    }

    [MenuItem(ToolsPath + Other + "UnSetup game for taking screenshots")]
    public static void UnSetupForScreenshots()
    {
      Screenshots screenshots = ScreenshotsHelper;
      if (screenshots != null)
        Object.DestroyImmediate(screenshots.gameObject);

      GameObject softbodyPrefab = Resources.Load<GameObject>(AssetPath.FromResourcesSolverBasePath);
      GameObject softbodyPrefabContents = PrefabUtility.LoadPrefabContents(AssetDatabase.GetAssetPath(softbodyPrefab));
      FluxyContainer fluxyContainer = softbodyPrefabContents.GetComponentInChildren<FluxyContainer>();
      fluxyContainer.UseMeshProjection = true;
      Object.DestroyImmediate(fluxyContainer.gameObject.GetComponent<AutoSetTargetColor>());
      FluxyTarget fluxyTarget = softbodyPrefabContents.GetComponentInChildren<FluxyTarget>();

      fluxyContainer.targets.Clear();
      Object.DestroyImmediate(fluxyTarget.gameObject);
      PrefabUtility.SaveAsPrefabAsset(softbodyPrefabContents, AssetDatabase.GetAssetPath(softbodyPrefab));
      SetDirtyCurrentScene();
    }

    [MenuItem(ToolsPath + Other + "Set camera screenshot position")]
    public static void SetCameraPos()
    {
      if (NotInPlaymode())
        return;

      ScreenshotsHelper.MoveCamera();
    }

    private static void SetDirtyCurrentScene() =>
      EditorSceneManager.MarkSceneDirty(SceneManager.GetActiveScene());

    private static void RefreshAssets()
    {
      AssetDatabase.SaveAssets();
      AssetDatabase.Refresh();
    }

    private static bool NotInPlaymode()
    {
      if (Application.isPlaying)
        return false;

      return true;
    }

    private static bool NotInPlayModeShowError()
    {
      if (NotInPlaymode())
      {
        Debug.LogError("You should enter playmode to use this");
        return true;
      }

      return false;
    }
  }
}