using System;
using System.Collections.Generic;
using UnityEngine;

namespace AmazonAds
{
	public abstract class AdResponse
	{
		public abstract string GetMoPubKeywords();

		public abstract IntPtr GetInstance();

		public abstract Dictionary<string, string> GetRendering(bool isSmartBanner = false, string fetchLabel = null);

		public abstract AdRequest GetAdLoader();

		public abstract string GetBidInfo();

		public abstract string GetPricePoint();

		public abstract int GetWidth();

		public abstract int GetHeight();

		public abstract string GetMediationHints(bool isSmartBanner = false);

		internal abstract void SetAdLoader(AdRequest adRequest);

		public abstract IntPtr GetIosResponseObject();

		public abstract AndroidJavaObject GetAndroidResponseObject();

		public abstract AndroidJavaObject GetResponse();
	}
}
