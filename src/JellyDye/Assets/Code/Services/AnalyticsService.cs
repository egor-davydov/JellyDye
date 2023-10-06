using GameAnalyticsSDK;
using Zenject;

namespace Code.Services
{
  public class AnalyticsService : IInitializable
  {
    public void Initialize()
    {
      GameAnalytics.Initialize();
    }

    public void LevelStart(int levelIndex, string levelId) => 
      GameAnalytics.NewProgressionEvent(GAProgressionStatus.Start, levelId);

    public void LevelEnd(int levelIndex, string levelId, int finalPercentage) => 
      GameAnalytics.NewProgressionEvent(GAProgressionStatus.Complete, levelId, finalPercentage);
  }
}