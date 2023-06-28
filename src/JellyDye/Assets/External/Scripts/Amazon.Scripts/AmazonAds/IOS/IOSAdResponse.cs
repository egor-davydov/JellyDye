using System;
using System.Collections.Generic;
using UnityEngine;

namespace AmazonAds.IOS
{
	public class IOSAdResponse : AdResponse
	{
		private IntPtr resp;

		private AdRequest adLoader;

		public IOSAdResponse()
		{
		}

		public IOSAdResponse(IntPtr response)
		{
		}

		public override int GetHeight()
		{
			return 0;
		}

		public override int GetWidth()
		{
			return 0;
		}

		public override string GetMoPubKeywords()
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

		public override string GetBidInfo()
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

		public override IntPtr GetInstance()
		{
			return (IntPtr)0;
		}

		public override AndroidJavaObject GetResponse()
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
