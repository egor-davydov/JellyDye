using GameAnalyticsSDK;
using Zenject;

namespace Code.Services
{
  public class AnalyticsService : IInitializable
  {
    private readonly StaticDataService _staticDataService;

    public AnalyticsService(StaticDataService staticDataService)
    {
      _staticDataService = staticDataService;
    }
    
    public void Initialize()
    {
      GameAnalytics.Initialize();
    }

    public void LevelStart(int levelIndex)
    {
      string levelName = _staticDataService.ForLevels().LevelConfigs[levelIndex].JelliesPrefab.name;
      GameAnalytics.NewProgressionEvent(GAProgressionStatus.Start, levelIndex.ToString(), levelName);
    }
    
    public void LevelEnd(int levelIndex, int finalPercentage)
    {
      string levelName = _staticDataService.ForLevels().LevelConfigs[levelIndex].JelliesPrefab.name;
      GameAnalytics.NewProgressionEvent(GAProgressionStatus.Complete, levelIndex.ToString(), levelName, finalPercentage);
    }
  }
}