using System.Collections.Generic;

namespace AmazonAds.IOS
{
	public class IOSPlatform : PlatformApi
	{
		public override void Initialization(string key)
		{
		}

		public override bool IsInitialized()
		{
			return false;
		}

		public override bool IsTestMode()
		{
			return false;
		}

		public override void EnableTesting(bool flag)
		{
		}

		public override void EnableLogging(bool flag)
		{
		}

		public override void UseGeoLocation(bool isLocationEnabled)
		{
		}

		public override bool IsLocationEnabled()
		{
			return false;
		}

		public override void SetMRAIDPolicy(Amazon.MRAIDPolicy policy)
		{
		}

		public override Amazon.MRAIDPolicy GetMRAIDPolicy()
		{
			return default(Amazon.MRAIDPolicy);
		}

		public override void SetMRAIDSupportedVersions(string[] versions)
		{
		}

		public override void AddSlotGroup(SlotGroup group)
		{
		}

		public override void SetCMPFlavor(Amazon.CMPFlavor cFlavor)
		{
		}

		public override void SetConsentStatus(Amazon.ConsentStatus consentStatus)
		{
		}

		public override void SetVendorList(List<int> vendorList)
		{
		}

		public override void AddCustomAttribute(string withKey, string value)
		{
		}

		public override void RemoveCustomAttr(string forKey)
		{
		}

		public override void SetAdNetworkInfo(AdNetworkInfo adNetworkInfo)
		{
		}
	}
}
