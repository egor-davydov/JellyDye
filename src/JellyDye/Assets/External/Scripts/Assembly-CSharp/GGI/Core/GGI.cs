using System;
using System.Collections;
using GGI.Ads;
using GGI.Components;
using GGI.Data.Responses.GameConfig;
using GGI.Internal.GDPR.Data;
using Google.Play.Review;
using com.adjust.sdk;

namespace GGI.Core
{
	public class GGI : AutoSingletonMono<GGI>
	{
		private GetGameConfigResponse _gameConfig;

		private GGICommandBuffer _cmdBuffer;

		public bool IsAttFlowCompleted;

		public Action OnAttFlowCompleted;

		public Action OnSDKInitComplete;

		public string UserCountryCode;

		public static Action OnApplicationWillEnterForeground;

		public static Action OnApplicationDidEnterBackground;

		public static string _environment;

		private ReviewManager _reviewManager;

		private PlayReviewInfo _reviewInfo;

		protected override void Awake()
		{
		}

		private void AdsRequested()
		{
		}

		private IEnumerator FirstAOAdLoadRoutine()
		{
			return null;
		}

		public void Init()
		{
		}

		public void InitAdjust()
		{
		}

		private void InitAds(GGIAds.MediationMode mediationMode)
		{
		}

		public void ToggleSRDebugger(bool t)
		{
		}

		public void OnApplicationQuit()
		{
		}

		private void OnConnectedToInternet()
		{
		}

		private void OnSdkInitComplete()
		{
		}

		private void GameConfigFetched()
		{
		}

		public void RequestAdvertisingIdentifier(Action<string> callback)
		{
		}

		public void OnLevelWin(int level)
		{
		}

		public void OnLevelLose(int level)
		{
		}

		public void InvokeATTFlowCompleted()
		{
		}

		private void OnBeforeAdsInit()
		{
		}

		private void OnGDPRFlowComplete(SessionConsentResult result)
		{
		}

		private IEnumerator CheckInternetConnection()
		{
			return null;
		}

		private IEnumerator InternetConnectionRoutine()
		{
			return null;
		}

		private IEnumerator GameDataCoroutine()
		{
			return null;
		}

		public string GetAdUnitId(AdUnitType unit)
		{
			return null;
		}

		public GGICommandBuffer GetCommandBuffer()
		{
			return null;
		}

		public void SetVIPUser()
		{
		}

		public bool IsVIPUser()
		{
			return false;
		}

		public GGIAds.MediationMode GetMediationMode()
		{
			return default(GGIAds.MediationMode);
		}

		public string GetAdjustAdId()
		{
			return null;
		}

		[Obsolete]
		public void ShowRateUs(bool force = false)
		{
		}

		private void OnApplicationPause(bool pauseStatus)
		{
		}

		public void TriggerOnPause()
		{
		}

		public void ApplicationWillTerminate()
		{
		}

		public void ApplicationWillEnterForeground()
		{
		}

		public void ApplicationDidEnterBackground()
		{
		}

		public void TryShowAOAdsAfterBecomingActive()
		{
		}

		public void ApplicationDidBecomeActive()
		{
		}

		public void OnAppOpenShowing()
		{
		}

		public void OnAppOpenClosing()
		{
		}

		public void OnLineItemFilled(string lineItem)
		{
		}

		public void OnLineItemFailed(string lineItem)
		{
		}

		public void OnLineItemExpired(string data)
		{
		}

		public void OnAdLoad(string lineItem)
		{
		}

		public void ATTAuthorizationStatusChanged(string status)
		{
		}

		private IEnumerator GetReviewInfoAndroid()
		{
			return null;
		}

		public IEnumerator StartReview()
		{
			return null;
		}

		private void AdjustAttributionChanged(AdjustAttribution attribution)
		{
		}

		private void EventSuccessCallback(AdjustEventSuccess obj)
		{
		}

		private void EventFailureCallback(AdjustEventFailure obj)
		{
		}

		private void SessionSuccessCallback(AdjustSessionSuccess obj)
		{
		}

		private void SessionFailureCallback(AdjustSessionFailure obj)
		{
		}

		public GGI()
		{
			((AutoSingletonMono<>)(object)this)._002Ector();
		}
	}
}
