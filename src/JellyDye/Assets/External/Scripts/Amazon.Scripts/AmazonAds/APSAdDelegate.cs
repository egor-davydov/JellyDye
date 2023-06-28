namespace AmazonAds
{
	public class APSAdDelegate
	{
		public delegate void OnAdLoaded();

		public delegate void OnAdFailed();

		public delegate void OnAdClicked();

		public delegate void OnAdOpen();

		public delegate void OnAdClosed();

		public delegate void OnImpressionFired();

		public delegate void OnVideoCompleted();

		public OnAdLoaded onAdLoaded;

		public OnAdFailed onAdFailed;

		public OnAdClicked onAdClicked;

		public OnAdOpen onAdOpen;

		public OnAdClosed onAdClosed;

		public OnImpressionFired onImpressionFired;

		public OnVideoCompleted onVideoCompleted;

		private static void OnAdLoadedImpl()
		{
		}

		private static void OnAdFailedImpl()
		{
		}

		private static void OnAdClickedImpl()
		{
		}

		private static void OnAdOpenImpl()
		{
		}

		private static void OnAdClosedImpl()
		{
		}

		private static void OnImpressionFiredImpl()
		{
		}

		private static void OnVideoCompletedImpl()
		{
		}
	}
}
