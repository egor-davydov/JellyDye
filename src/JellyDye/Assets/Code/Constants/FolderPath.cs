namespace Code.Constants
{
  public static class FolderPath
  {
    public const string ResourcesFolderAbsolutePath = "Assets/Resources";
    
    public static readonly string AbsoluteBlueprintsPath = $"{ResourcesFolderAbsolutePath}/{ResourcesBlueprintsPath}";
    public static readonly string AbsolutePrefabsPath = $"{ResourcesFolderAbsolutePath}/{ResourcesPrefabsPath}";
    
    public const string ResourcesBlueprintsPath = "Levels/MeshesAndBlueprints";
    public const string ResourcesPrefabsPath = "Levels/Jellies";
    public const string ResourcesScreenshotsPath = "Levels/TargetColorScreenshots";
  }
}