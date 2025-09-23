using UnityEditor;
using UnityEditor.SceneManagement;

namespace Code.Editor
{
  [InitializeOnLoad]
  public static class EntryPointSceneAutoLoader
  {
    static EntryPointSceneAutoLoader()
    {
      if (EditorBuildSettings.scenes.Length == 0)
        return;

      EditorSceneManager.playModeStartScene = AssetDatabase
        .LoadAssetAtPath<SceneAsset>(EditorBuildSettings.scenes[0].path);
    }
  }
}