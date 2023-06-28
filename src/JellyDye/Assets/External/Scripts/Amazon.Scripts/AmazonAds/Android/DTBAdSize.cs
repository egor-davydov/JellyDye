using UnityEngine;

namespace AmazonAds.Android
{
	public class DTBAdSize : IAdSize
	{
		public class DTBInterstitialAdSize : IInterstitialAdSize
		{
			private AndroidJavaObject client;

			public DTBInterstitialAdSize(string slotUUID)
			{
			}

			public AndroidJavaObject GetInstance()
			{
				return null;
			}
		}

		public class DTBVideo : IVideo
		{
			public AndroidJavaObject client;

			public DTBVideo(int playerWidth, int playerHeight, string slotUUID)
			{
			}

			public AndroidJavaObject GetInstance()
			{
				return null;
			}
		}

		private AndroidJavaObject client;

		public DTBAdSize(int width, int height, string slotUUID)
		{
		}

		public int GetWidth()
		{
			return 0;
		}

		public int GetHeight()
		{
			return 0;
		}

		public string GetSlotUUID()
		{
			return null;
		}

		public AndroidJavaObject GetInstance()
		{
			return null;
		}
	}
}
