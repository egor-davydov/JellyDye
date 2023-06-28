using System;

namespace GGI.Internal.Android
{
	public class AdvertisingIdFetcher
	{
		private Action<string> mCallback;

		public static void RequestAdvertisingId(Action<string> callback)
		{
		}

		private void DoRequestAdvertisingId(Action<string> callback)
		{
		}

		private void OnAdvertisingIdReceived(string advertisingId)
		{
		}

		private void OnAdvertisingIdReceived(string advertisingId, bool trackingEnabled, string errorMsg)
		{
		}
	}
}
