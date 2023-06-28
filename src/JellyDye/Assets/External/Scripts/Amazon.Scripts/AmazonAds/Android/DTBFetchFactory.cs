using UnityEngine;

namespace AmazonAds.Android
{
	public class DTBFetchFactory
	{
		private static readonly AndroidJavaClass dTBFetchFactoryClass;

		private AndroidJavaObject dTBFetchFactory;

		public DTBFetchFactory(AndroidJavaObject obj)
		{
		}

		public static DTBFetchFactory GetInstance()
		{
			return null;
		}

		public DTBFetchManager GetFetchManager(string label)
		{
			return null;
		}

		public DTBFetchManager createFetchManager(string label, AndroidJavaObject loader)
		{
			return null;
		}

		public DTBFetchManager createFetchManager(string label, AndroidJavaObject loader, bool isSmartBanner)
		{
			return null;
		}

		public void removeFetchManager(string label)
		{
		}
	}
}
