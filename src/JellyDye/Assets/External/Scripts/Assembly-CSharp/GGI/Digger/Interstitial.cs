namespace GGI.Digger
{
	public static class Interstitial
	{
		private static bool _firstInterstitialImpression;

		private static Digger.FirstSessionMode _interFirstSessionMode;

		private static Digger.Mode _interStartMode;

		private static Digger.Mode _interMode;

		private static float _interStartStep;

		private static float _interStep;

		private static float _interResetStep;

		private static bool InterstitialEnabled()
		{
			return false;
		}

		private static Digger.Mode InterstitialMode()
		{
			return default(Digger.Mode);
		}

		private static Digger.Mode InterstitialStartMode()
		{
			return default(Digger.Mode);
		}

		private static Digger.FirstSessionMode InterstitialFirstSessionMode()
		{
			return default(Digger.FirstSessionMode);
		}

		private static float InterstitialStep()
		{
			return 0f;
		}

		private static float InterstitialResetStep()
		{
			return 0f;
		}

		private static float InterstitialStartStep()
		{
			return 0f;
		}

		private static void SetInterstitialCpm(float cpm)
		{
		}

		private static float GetInterstitialCpm(Digger.Mode mode)
		{
			return 0f;
		}

		private static float ValidateInterstitialCpm(float cpm)
		{
			return 0f;
		}

		public static void SetInterstitialCeiling(string adUnit, float cpm)
		{
		}

		public static void SetFirstInterstitialCeiling(string adUnit)
		{
		}

		private static void SetFirstSessionFirstImpressionInterstitialCeiling(string adUnit)
		{
		}
	}
}
