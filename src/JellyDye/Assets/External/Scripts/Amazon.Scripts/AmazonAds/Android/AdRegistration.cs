using System.Collections.Generic;
using UnityEngine;

namespace AmazonAds.Android
{
	public class AdRegistration
	{
		public class SlotGroup
		{
			private readonly AndroidJavaClass slotGroup;

			public AndroidJavaObject dTBSlot;

			public SlotGroup()
			{
			}

			public SlotGroup(string name)
			{
			}

			public void AddSlot(IAdSize size)
			{
			}
		}

		private static readonly AndroidJavaClass adRegistrationClass;

		private AndroidJavaObject adRegistration;

		public void AddProvider(AndroidJavaObject provider)
		{
		}

		public AndroidJavaObject GetEventDistributer()
		{
			return null;
		}

		public HashSet<AndroidJavaObject> GtAdProviders()
		{
			return null;
		}

		public List<string> GetProprietaryProviderKeys()
		{
			return null;
		}

		public string GetAppKey()
		{
			return null;
		}

		public bool IsInitialized()
		{
			return false;
		}

		public AndroidJavaObject GetInstance(string appKey)
		{
			return null;
		}

		public void SetMRAIDPolicy(Amazon.MRAIDPolicy policy)
		{
		}

		public Amazon.MRAIDPolicy GetMRAIDPolicy()
		{
			return default(Amazon.MRAIDPolicy);
		}

		public void SetMRAIDSupportedVersions(string[] versions)
		{
		}

		public void EnableLogging(bool enable)
		{
		}

		public void EnableLogging(bool enable, AndroidJavaObject logLevel)
		{
		}

		public void EnableTesting(bool isTesting)
		{
		}

		public bool IsTestMode()
		{
			return false;
		}

		public void UseGeoLocation(bool isLocationEnabled)
		{
		}

		public bool IsLocationEnabled()
		{
			return false;
		}

		public string GetVersion()
		{
			return null;
		}

		public void SetServerlessMarkers(string[] markers)
		{
		}

		public void AddSlotGroup(SlotGroup sg)
		{
		}

		public AndroidJavaObject GetSlotGroup(string name)
		{
			return null;
		}

		public bool IsConsentStatusUnknown()
		{
			return false;
		}

		public void SetVendorList(List<int> vendorList)
		{
		}

		public void SetConsentStatus(Amazon.ConsentStatus consentStatus)
		{
		}

		public void SetCMPFlavor(Amazon.CMPFlavor cFlavor)
		{
		}

		public void ResetNonIAB()
		{
		}

		public void AddCustomAttribute(string withKey, string value)
		{
		}

		public void RemoveCustomAttr(string forKey)
		{
		}

		public void SetAdNetworkInfo(string adNetworkName)
		{
		}
	}
}
