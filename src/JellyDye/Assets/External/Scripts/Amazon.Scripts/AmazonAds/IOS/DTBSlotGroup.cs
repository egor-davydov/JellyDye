using System;

namespace AmazonAds.IOS
{
	public class DTBSlotGroup : ISlotGroup
	{
		private IntPtr client;

		public DTBSlotGroup(string slotGroupName)
		{
		}

		public void AddSlot(int width, int height, string uid)
		{
		}

		public void AddSlot(AdSize size)
		{
		}

		public IntPtr GetInstance()
		{
			return (IntPtr)0;
		}
	}
}
