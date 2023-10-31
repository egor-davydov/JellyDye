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

    [MenuItem(ToolsPath+"Delete Progress file")]
    public static void ClearProgress() => 
      File.Delete(FileSaveLoadService.ProgressFilePath);

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

    [MenuItem(ToolsPath+"Take Screenshots without ground")]
    public static void TakeScreenshotsWithoutGround()
    {
      if (NotInPlaymode())
        return;

      Object.FindObjectOfType<Screenshots>().TakeScreenshotsWithoutGround();
    }
    [MenuItem(ToolsPath+"Setup game for taking screenshots")]
    public static void SetupForScreenshots()
    {
      GameObject helpersPrefab = AssetDatabase.LoadAssetAtPath<GameObject>("Assets/SceneAssets/Helpers.prefab");
      if(Object.FindObjectOfType<Screenshots>() == null)
        PrefabUtility.InstantiatePrefab(helpersPrefab);
      GameObject targetPrefab = AssetDatabase.LoadAssetAtPath<GameObject>("Assets/SceneAssets/Target.prefab");
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
    [MenuItem(ToolsPath+"UnSetup game for taking screenshots")]
    public static void UnSetupForScreenshots()
    {
      Screenshots screenshots = Object.FindObjectOfType<Screenshots>();
      if(screenshots == null)
        Object.DestroyImmediate(screenshots.gameObject, true);
      
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

    private static void SetDirtyCurrentScene() => 
      EditorSceneManager.MarkSceneDirty(EditorSceneManager.GetActiveScene());

    [MenuItem(ToolsPath+"Take Screenshots")]
    public static void TakeScreenshots()
    {
      if (NotInPlaymode())
        return;

      Object.FindObjectOfType<Screenshots>().TakeScreenshots();
    }

    [MenuItem(ToolsPath+"Set camera screenshot position")]
    public static void SetCameraPos()
    {
      if (NotInPlaymode())
        return;

      Object.FindObjectOfType<Screenshots>().MoveCamera();
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