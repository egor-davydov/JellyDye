using System.Collections.Generic;
using Firebase.Messaging;
using GGI.Ads;
using GGI.Analytics.Events;
using GGI.Data.Responses.Stepback;

namespace GGI.Analytics
{
	public class FirebaseHandler
	{
		private string _fcmToken;

		private string _instanceId;

		public void Init()
		{
		}

		private void OnFirebaseTokenReceived(object sender, TokenReceivedEventArgs args)
		{
		}

		public string GetFCMToken()
		{
			return null;
		}

		public string GetInstanceID()
		{
			return null;
		}

		public void LogLevelEvent(int progress, int level, LevelStatus status, double? time, Dictionary<string, object> extraParams = null)
		{
		}

		public void LogLevelEvent(int progress, string level, LevelStatus status, double? time, Dictionary<string, object> extraParams = null)
		{
		}

		public void LogMarketEvent(string type, int id, double cost)
		{
		}

		public void LogMarketEvent(string type, string id, double cost)
		{
		}

		public void LogInAppPurchase(string productName, string currency, double price, bool validated)
		{
		}

		public void LogGenericEvent(string key)
		{
		}

		public void LogGenericEventWithParams(string key, Dictionary<string, object> extraParams)
		{
		}

		public void LogAdImpression(AdUnitType type, string networkName, string placementId, double revenue, string creativeId, string adUnitId, string adFormat, string rewardedPlace = "")
		{
		}

		public void LogAdRequest(AdUnitType type)
		{
		}

		public void LogAdStatistics(AdUnitType type, double time, MaxSdkBase.AdInfo adInfo)
		{
		}

		public void LogMissedOpportunity(AdUnitType type)
		{
		}

		public void LogCrossPromoImpression(string gameId, string gameName, string creative)
		{
		}

		public void LogCrossPromoClick(string gameId, string gameName, string creative)
		{
		}

		public void LogLineItemEvent(StepbackFillEvent fill, bool success)
		{
		}

		public void LogRateUsChoice(int session, int level, bool choice)
		{
		}

		public void LogRealtimeRevenue(double revenue)
		{
		}
	}
}
