public class AnalyticsManager : MonoSingleton<AnalyticsManager>
{
	public void OnLevelFail(int progress, int levelId, float levelTimer)
	{
	}

	public void OnLevelSuccess(int progress, int levelId, float levelTimer)
	{
	}

	public void OnLevelStart(int progress, int levelId)
	{
	}

	public void OnVIPButton()
	{
	}

	public AnalyticsManager()
	{
		((MonoSingleton<>)(object)this)._002Ector();
	}
}
