using System.IO;
using Code.Helpers;
using Code.Services.Progress.SaveLoad;
using UnityEditor;
using UnityEngine;

namespace Code.Editor
{
  public static class Tools
  {
    [MenuItem("Tools/Delete Progress file")]
    public static void ClearProgress()
    {
      File.Delete(FileSaveLoadService.ProgressFilePath);
    }

    [MenuItem("Tools/Setup Screenshots")]
    public static void SetupScreenshots()
    {
      if (NotInPlaymode())
        return;

      Object.FindObjectOfType<Screenshots>().SetupAllScreenshots();
    }

    [MenuItem("Tools/Take Screenshots without ground")]
    public static void TakeScreenshotsWithoutGround()
    {
      if (NotInPlaymode())
        return;

      Object.FindObjectOfType<Screenshots>().TakeScreenshotsWithoutGround();
    }

    [MenuItem("Tools/Take Screenshots")]
    public static void TakeScreenshots()
    {
      if (NotInPlaymode())
        return;

      Object.FindObjectOfType<Screenshots>().TakeScreenshots();
    }

    [MenuItem("Tools/set camera pos")]
    public static void SetCameraPos()
    {
      if (NotInPlaymode())
        return;

      Object.FindObjectOfType<Screenshots>().MoveCamera();
    }

    private static bool NotInPlaymode()
    {
      if (!Application.isPlaying)
      {
        Debug.LogError("You should enter playmode to use this");
        return true;
      }

      return false;
    }
  }
}