using UnityEngine;

namespace AmazonAds.Android
{
	public class DTBFetchManager : IFetchManager
	{
		private static readonly AndroidJavaClass dTBFetchManagerClass;

		private AndroidJavaObject dTBFetchManager;

		public DTBFetchManager(AndroidJavaObject client)
		{
		}

		public void dispense()
		{
		}

		public void start()
		{
		}

		public void stop()
		{
		}

		public bool isEmpty()
		{
			return false;
		}

		public AdResponse peek()
		{
			return null;
		}
	}
}
