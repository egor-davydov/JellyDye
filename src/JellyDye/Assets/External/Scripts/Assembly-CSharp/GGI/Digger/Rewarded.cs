namespace GGI.Digger
{
	public static class Rewarded
	{
		private static bool _firstRewardedImpression;

		private static Digger.FirstSessionMode _rewardedFirstSessionMode;

		private static Digger.Mode _rewardedStartMode;

		private static Digger.Mode _rewardedMode;

		private static float _rewardedStartStep;

		private static float _rewardedStep;

		private static float _rewardedResetStep;

		private static bool RewardedEnabled()
		{
			return false;
		}

		private static Digger.Mode RewardedMode()
		{
			return default(Digger.Mode);
		}

		private static Digger.Mode RewardedStartMode()
		{
			return default(Digger.Mode);
		}

		private static Digger.FirstSessionMode RewardedFirstSessionMode()
		{
			return default(Digger.FirstSessionMode);
		}

		private static float RewardedStep()
		{
			return 0f;
		}

		private static float RewardedResetStep()
		{
			return 0f;
		}

		private static float RewardedStartStep()
		{
			return 0f;
		}

		private static void SetRewardedCpm(float cpm)
		{
		}

		private static float GetRewardedCpm(Digger.Mode mode)
		{
			return 0f;
		}

		private static float ValidateRewardedCpm(float cpm)
		{
			return 0f;
		}

		public static void SetRewardedCeiling(string adUnit, float cpm)
		{
		}

		public static void SetFirstRewardedCeiling(string adUnit)
		{
		}

		private static void SetFirstSessionFirstImpressionRewardedCeiling(string adUnit)
		{
		}
	}
}
