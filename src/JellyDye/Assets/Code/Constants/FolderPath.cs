namespace Code.Constants
{
  public static class FolderPath
  {
    public const string ResourcesPath = "Assets/Resources";
    public const string AddressablesPath = "Assets/Resources_moved";

    public static readonly string AbsoluteBlueprintsPath = $"{ResourcesPath}/{FromResourcesBlueprintsPath}";
    public static readonly string AbsoluteMeshesPath = $"{AddressablesPath}/{FromResourcesBlueprintsPath}";
    public static readonly string AbsoluteJelliesPath = $"{AddressablesPath}/{FromResourcesJelliesPath}";
    public static readonly string AbsoluteJelliesBasePath = $"{ResourcesPath}/{FromResourcesJelliesPath}";

    public const string FromResourcesBlueprintsPath = "Levels";
    public const string FromResourcesJelliesPath = "Levels";
    public const string FromResourcesScreenshotsPath = "TargetColorScreenshots";
  }
}