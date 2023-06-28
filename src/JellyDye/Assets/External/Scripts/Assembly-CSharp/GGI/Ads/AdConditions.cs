using GGI.Analytics.Events;

namespace GGI.Ads
{
	public class AdConditions
	{
		public enum AdIntervalConfig
		{
			Default = 0,
			TimeBased = 1,
			SessionBased = 2,
			AdsBased = 3,
			SessionAdBased = 4
		}

		private float _lastInterstitialShownTime;

		private float _lastRewardedShownTime;

		private int _currentInterRewardedIndex;

		private int _interImpressionsInRewardedInterval;

		private LevelStatus _lastLevelStatus;

		private int _lastLoseLevelIndex;

		public bool AreConditionsMet()
		{
			return false;
		}

		public void OnLevelSuccess()
		{
		}

		public void OnLevelFailed()
		{
		}

		public void InterstitialDisplayed()
		{
		}

		public void RewardedVideoDisplayed(bool completed)
		{
		}

		private int GetCurrentAdInterval()
		{
			return 0;
		}
	}
}
