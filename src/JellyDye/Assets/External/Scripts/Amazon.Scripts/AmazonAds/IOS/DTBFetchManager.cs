using System;

namespace AmazonAds.IOS
{
	public class DTBFetchManager : IFetchManager
	{
		protected enum DTBSlotType
		{
			SLOT_320_50 = 0,
			SLOT_300_250 = 1,
			SLOT_728_90 = 2,
			SLOT_SMART = 3
		}

		private IntPtr fetchManager;

		public DTBFetchManager(DTBAdRequest adLoader, string autoRefreshID, bool isSmartBanner)
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

		public void destroy(string autoRefreshID)
		{
		}
	}
}
