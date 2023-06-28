namespace AmazonAds
{
	public class AdSize
	{
		public class InterstitialAdSize
		{
			private IInterstitialAdSize client;

			public InterstitialAdSize(string slotUID)
			{
			}

			public IInterstitialAdSize GetInstance()
			{
				return null;
			}
		}

		public class Video
		{
			private IVideo client;

			public Video(int playerWidth, int playerHeight, string slotUUID)
			{
			}

			public IVideo GetInstance()
			{
				return null;
			}
		}

		private IAdSize client;

		public AdSize(int width, int height, string slotUID)
		{
		}

		public IAdSize GetInstance()
		{
			return null;
		}
	}
}
