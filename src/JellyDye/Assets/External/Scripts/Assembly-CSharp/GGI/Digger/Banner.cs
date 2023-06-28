namespace GGI.Digger
{
	public static class Banner
	{
		private static bool _firstBannerImpression;

		private static Digger.FirstSessionMode _bannerFirstSessionMode;

		private static Digger.Mode _bannerStartMode;

		private static Digger.Mode _bannerMode;

		private static float _bannerStartStep;

		private static float _bannerStep;

		private static float _bannerResetStep;

		private static bool BannerEnabled()
		{
			return false;
		}

		private static Digger.Mode BannerMode()
		{
			return default(Digger.Mode);
		}

		private static Digger.Mode BannerStartMode()
		{
			return default(Digger.Mode);
		}

		private static Digger.FirstSessionMode BannerFirstSessionMode()
		{
			return default(Digger.FirstSessionMode);
		}

		private static float BannerStep()
		{
			return 0f;
		}

		private static float BannerStartStep()
		{
			return 0f;
		}

		private static float BannerResetStep()
		{
			return 0f;
		}

		private static void SetBannerCpm(float cpm)
		{
		}

		private static float GetBannerCpm(Digger.Mode mode)
		{
			return 0f;
		}

		private static float ValidateBannerCpm(float cpm)
		{
			return 0f;
		}

		public static void SetBannerCeiling(string adUnit, float cpm)
		{
		}

		public static void SetFirstBannerCeiling(string adUnit)
		{
		}

		private static void SetFirstSessionFirstImpressionBannerCeiling(string adUnit)
		{
		}
	}
}
