using System.IO;
using Code.Services.Progress.SaveLoad;
using UnityEditor;

namespace Code.Editor
{
  public static class Tools
  {
    [MenuItem("Tools/Delete Progress file")]
    public static void ClearProgress()
    {
      File.Delete(FileSaveLoadService.ProgressFilePath);
    }
  }
}