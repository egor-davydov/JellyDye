using System.IO;
using Code.Constants;
using Code.Helpers;
using Code.Services.Progress.SaveLoad;
using Fluxy;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;

namespace Code.Editor
{
  public static class Tools
  {
    private const string ToolsPath = "Tools/Custom/";
    private const string Screenshots = "Take screenshots/";
    private const string Other = "Other/";
    
    private static Screenshots ScreenshotsHelper => Object.FindObjectOfType<Screenshots>();

    [MenuItem(ToolsPath+"Delete Progress file")]
    public static void ClearProgress() => 
      File.Delete(FilePath.ProgressPath);

    [MenuItem(ToolsPath+"Delete files in \"JelliesToAdd\" folder, that ends with \"d1\"")]
    public static void DeleteFiles()
    {
      string[] files = Directory.GetFiles("Assets/Resources/Levels/JelliesToAdd");
      foreach (string file in files)
      {
        string[] strings = file.Split('.');
        if(strings[0].EndsWith("d1"))
          File.Delete(file);
      }
      AssetDatabase.SaveAssets();
      AssetDatabase.Refresh();
    }

    [MenuItem(ToolsPath+Screenshots+"All")]
    public static void TakeScreenshots()
    {
      if (NotInPlaymode())
        return;

      ScreenshotsHelper.TakeScreenshots(withGround: true, () =>
      {
        
        TakeScreenshotsWithGround();
      });
    }

    [MenuItem(ToolsPath+Screenshots+"With ground")]
    public static void TakeScreenshotsWithGround()
    {
      if (NotInPlaymode())
        return;

      ScreenshotsHelper.TakeScreenshots(withGround: true, RefreshAssets);
    }

    [MenuItem(ToolsPath+Screenshots+"Without ground")]
    public static void TakeScreenshotsWithoutGround()
    {
      if (NotInPlaymode())
        return;

      ScreenshotsHelper.TakeScreenshots(withGround: false, RefreshAssets);
    }

    [MenuItem(ToolsPath+Other+"Setup game for taking screenshots")]
    public static void SetupForScreenshots()
    {
      GameObject helpersPrefab = AssetDatabase.LoadAssetAtPath<GameObject>("Assets/SceneAssets/Helpers.prefab");
      if(Object.FindObjectOfType<Screenshots>() == null)
        PrefabUtility.InstantiatePrefab(helpersPrefab);
      GameObject targetPrefab = AssetDatabase.LoadAssetAtPath<GameObject>("Assets/SceneAssets/PaintAllContainerTarget.prefab");
      GameObject softbodyPrefab = Resources.Load<GameObject>($"{FolderPath.ResourcesPrefabsPath}/{AssetName.SoftbodySolver}");
      GameObject softbodyPrefabContents = PrefabUtility.LoadPrefabContents(AssetDatabase.GetAssetPath(softbodyPrefab));
      FluxyContainer fluxyContainer = softbodyPrefabContents.GetComponentInChildren<FluxyContainer>();

      fluxyContainer.UseMeshProjection = false;
      fluxyContainer.gameObject.AddComponent<AutoSetTargetColor>();
      
      GameObject targetObject = (GameObject)PrefabUtility.InstantiatePrefab(targetPrefab, fluxyContainer.transform);
      targetObject.transform.position = Vector3.zero;
      
      fluxyContainer.targets.Add(targetObject.GetComponent<FluxyTarget>());
      
      PrefabUtility.SaveAsPrefabAsset(softbodyPrefabContents, AssetDatabase.GetAssetPath(softbodyPrefab));
      SetDirtyCurrentScene();
    }

    [MenuItem(ToolsPath+Other+"UnSetup game for taking screenshots")]
    public static void UnSetupForScreenshots()
    {
      Screenshots screenshots = ScreenshotsHelper;
      if(screenshots != null)
        Object.DestroyImmediate(screenshots.gameObject);
      
      GameObject softbodyPrefab = Resources.Load<GameObject>($"{FolderPath.ResourcesPrefabsPath}/{AssetName.SoftbodySolver}");
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

    [MenuItem(ToolsPath+Other+"Set camera screenshot position")]
    public static void SetCameraPos()
    {
      if (NotInPlaymode())
        return;

      Object.FindObjectOfType<Screenshots>().MoveCamera();
    }

    private static void SetDirtyCurrentScene() => 
      EditorSceneManager.MarkSceneDirty(EditorSceneManager.GetActiveScene());

    private static void RefreshAssets()
    {
      AssetDatabase.SaveAssets();
      AssetDatabase.Refresh();
    }

    private static bool NotInPlaymode()
    {
      if (Application.isPlaying)
        return false;
      
      Debug.LogError("You should enter playmode to use this");
      return true;
    }
  }
}