using System;
using System.Collections.Generic;
using UnityEngine;

namespace AmazonAds.Android
{
	public class AndroidAdResponse : AdResponse
	{
		private AndroidJavaObject response;

		private AdRequest adLoader;

		private static readonly AndroidJavaClass sdkUtilitiesClass;

		public AndroidAdResponse()
		{
		}

		public AndroidAdResponse(AndroidJavaObject newResponse)
		{
		}

		public override IntPtr GetInstance()
		{
			return (IntPtr)0;
		}

		public override string GetBidInfo()
		{
			return null;
		}

		public override IntPtr GetIosResponseObject()
		{
			return (IntPtr)0;
		}

		public override AndroidJavaObject GetAndroidResponseObject()
		{
			return null;
		}

		public override string GetPricePoint()
		{
			return null;
		}

		public override string GetMediationHints(bool isSmartBanner = false)
		{
			return null;
		}

		public override int GetHeight()
		{
			return 0;
		}

		public override int GetWidth()
		{
			return 0;
		}

		public override AndroidJavaObject GetResponse()
		{
			return null;
		}

		public override string GetMoPubKeywords()
		{
			return null;
		}

		public override Dictionary<string, string> GetRendering(bool isSmartBanner = false, string fetchLabel = null)
		{
			return null;
		}

		public override AdRequest GetAdLoader()
		{
			return null;
		}

		internal override void SetAdLoader(AdRequest adRequest)
		{
		}
	}
}
