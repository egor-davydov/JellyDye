using System;

namespace AmazonAds.IOS
{
	public class DTBAdSize : IAdSize
	{
		public class DTBInterstitialAdSize : IInterstitialAdSize
		{
			private IntPtr client;

			public DTBInterstitialAdSize(string slotUUID)
			{
			}

			public IntPtr GetInstance()
			{
				return (IntPtr)0;
			}
		}

		public class DTBVideo : IVideo
		{
			public IntPtr client;

			public DTBVideo(int playerWidth, int playerHeight, string slotUUID)
			{
			}

			public IntPtr GetInstance()
			{
				return (IntPtr)0;
			}
		}

		private IntPtr client;

		private int width;

		private int height;

		private string slotUUID;

		public DTBAdSize(int width, int height, string slotUUID)
		{
		}

		public int GetHeight()
		{
			return 0;
		}

		public IntPtr GetInstance()
		{
			return (IntPtr)0;
		}

		public string GetSlotUUID()
		{
			return null;
		}

		public int GetWidth()
		{
			return 0;
		}
	}
}
