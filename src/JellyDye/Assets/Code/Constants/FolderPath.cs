namespace Code.Constants
{
  public static class FolderPath
  {
    public const string ResourcesPath = "Assets/Resources";
    
    public static readonly string AbsoluteBlueprintsPath = $"{ResourcesPath}/{ResourcesBlueprintsPath}";
    public static readonly string AbsolutePrefabsPath = $"{ResourcesPath}/{ResourcesPrefabsPath}";
    
    public const string ResourcesBlueprintsPath = "Levels/MeshesAndBlueprints";
    public const string ResourcesPrefabsPath = "Levels/Jellies";
    public const string ResourcesScreenshotsPath = "Levels/TargetColorScreenshots";
  }
}