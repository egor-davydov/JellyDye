using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Facebook.Unity.Mobile.Android
{
	internal sealed class AndroidFacebook : MobileFacebook
	{
		private class JavaMethodCall<T> : MethodCall<T> where T : IResult
		{
			private AndroidFacebook androidImpl;

			public JavaMethodCall(AndroidFacebook androidImpl, string methodName)
			{
				((MethodCall<>)(object)this)._002Ector((FacebookBase)null, (string)null);
			}

			public override void Call(MethodArguments args = null)
			{
			}
		}

		private bool limitEventUsage;

		private IAndroidWrapper androidWrapper;

		private string userID;

		private string KeyHash
		{
			[CompilerGenerated]
			set
			{
			}
		}

		public override bool LimitEventUsage
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public override string SDKName => null;

		public override string SDKVersion => null;

		public AndroidFacebook()
			: base(null)
		{
		}

		public AndroidFacebook(IAndroidWrapper androidWrapper, CallbackManager callbackManager)
			: base(null)
		{
		}

		public void Init(string appId, string clientToken, HideUnityDelegate hideUnityDelegate, InitDelegate onInitComplete)
		{
		}

		public override void LoginWithTrackingPreference(string tracking, IEnumerable<string> permissions, string nonce, FacebookDelegate<ILoginResult> callback)
		{
		}

		public override void LogInWithReadPermissions(IEnumerable<string> permissions, FacebookDelegate<ILoginResult> callback)
		{
		}

		public override void LogInWithPublishPermissions(IEnumerable<string> permissions, FacebookDelegate<ILoginResult> callback)
		{
		}

		public override void LogOut()
		{
		}

		public override AuthenticationToken CurrentAuthenticationToken()
		{
			return null;
		}

		public override Profile CurrentProfile()
		{
			return null;
		}

		public void OnLoginStatusRetrieved(ResultContainer resultContainer)
		{
		}

		public override void AppRequest(string message, OGActionType? actionType, string objectId, IEnumerable<string> to, IEnumerable<object> filters, IEnumerable<string> excludeIds, int? maxRecipients, string data, string title, FacebookDelegate<IAppRequestResult> callback)
		{
		}

		public override void ShareLink(Uri contentURL, string contentTitle, string contentDescription, Uri photoURL, FacebookDelegate<IShareResult> callback)
		{
		}

		public override void FeedShare(string toId, Uri link, string linkName, string linkCaption, string linkDescription, Uri picture, string mediaSource, FacebookDelegate<IShareResult> callback)
		{
		}

		public override void GetAppLink(FacebookDelegate<IAppLinkResult> callback)
		{
		}

		public override void AppEventsLogEvent(string logEvent, float? valueToSum, Dictionary<string, object> parameters)
		{
		}

		public override void AppEventsLogPurchase(float logPurchase, string currency, Dictionary<string, object> parameters)
		{
		}

		public override bool IsImplicitPurchaseLoggingEnabled()
		{
			return false;
		}

		public override void ActivateApp(string appId)
		{
		}

		public override void FetchDeferredAppLink(FacebookDelegate<IAppLinkResult> callback)
		{
		}

		public override void RefreshCurrentAccessToken(FacebookDelegate<IAccessTokenRefreshResult> callback)
		{
		}

		public override void OpenFriendFinderDialog(FacebookDelegate<IGamingServicesFriendFinderResult> callback)
		{
		}

		public override void GetFriendFinderInvitations(FacebookDelegate<IFriendFinderInvitationResult> callback)
		{
		}

		public override void DeleteFriendFinderInvitation(string invitationId, FacebookDelegate<IFriendFinderInvitationResult> callback)
		{
		}

		public override void UploadImageToMediaLibrary(string caption, Uri imageUri, bool shouldLaunchMediaDialog, FacebookDelegate<IMediaUploadResult> callback)
		{
		}

		public override void UploadVideoToMediaLibrary(string caption, Uri videoUri, bool shouldLaunchMediaDialog, FacebookDelegate<IMediaUploadResult> callback)
		{
		}

		public override void GetUserLocale(FacebookDelegate<ILocaleResult> callback)
		{
		}

		public override void OnIAPReady(FacebookDelegate<IIAPReadyResult> callback)
		{
		}

		public override void GetCatalog(FacebookDelegate<ICatalogResult> callback)
		{
		}

		public override void GetPurchases(FacebookDelegate<IPurchasesResult> callback)
		{
		}

		public override void Purchase(string productID, FacebookDelegate<IPurchaseResult> callback, string developerPayload = "")
		{
		}

		public override void ConsumePurchase(string purchaseToken, FacebookDelegate<IConsumePurchaseResult> callback)
		{
		}

		public override void InitCloudGame(FacebookDelegate<IInitCloudGameResult> callback)
		{
		}

		public override void GameLoadComplete(FacebookDelegate<IGameLoadCompleteResult> callback)
		{
		}

		public override void ScheduleAppToUserNotification(string title, string body, Uri media, int timeInterval, string payload, FacebookDelegate<IScheduleAppToUserNotificationResult> callback)
		{
		}

		public override void LoadInterstitialAd(string placementID, FacebookDelegate<IInterstitialAdResult> callback)
		{
		}

		public override void ShowInterstitialAd(string placementID, FacebookDelegate<IInterstitialAdResult> callback)
		{
		}

		public override void LoadRewardedVideo(string placementID, FacebookDelegate<IRewardedVideoResult> callback)
		{
		}

		public override void ShowRewardedVideo(string placementID, FacebookDelegate<IRewardedVideoResult> callback)
		{
		}

		public override void GetPayload(FacebookDelegate<IPayloadResult> callback)
		{
		}

		public override void PostSessionScore(int score, FacebookDelegate<ISessionScoreResult> callback)
		{
		}

		public override void PostTournamentScore(int score, FacebookDelegate<ITournamentScoreResult> callback)
		{
		}

		public override void GetTournament(FacebookDelegate<ITournamentResult> callback)
		{
		}

		public override void CreateTournament(int initialScore, string title, string imageBase64DataUrl, string sortOrder, string scoreFormat, Dictionary<string, string> data, FacebookDelegate<ITournamentResult> callback)
		{
		}

		public override void ShareTournament(int score, Dictionary<string, string> data, FacebookDelegate<ITournamentScoreResult> callback)
		{
		}

		public override void GetTournaments(FacebookDelegate<IGetTournamentsResult> callback)
		{
		}

		public override void UpdateTournament(string tournamentID, int score, FacebookDelegate<ITournamentScoreResult> callback)
		{
		}

		public override void UpdateAndShareTournament(string tournamentID, int score, FacebookDelegate<IDialogResult> callback)
		{
		}

		public override void CreateAndShareTournament(int initialScore, string title, TournamentSortOrder sortOrder, TournamentScoreFormat scoreFormat, long endTime, string payload, FacebookDelegate<IDialogResult> callback)
		{
		}

		public override void OpenAppStore(FacebookDelegate<IOpenAppStoreResult> callback)
		{
		}

		public override void CreateGamingContext(string playerID, FacebookDelegate<ICreateGamingContextResult> callback)
		{
		}

		public override void SwitchGamingContext(string gamingContextID, FacebookDelegate<ISwitchGamingContextResult> callback)
		{
		}

		public override void ChooseGamingContext(List<string> filters, int minSize, int maxSize, FacebookDelegate<IChooseGamingContextResult> callback)
		{
		}

		public override void GetCurrentGamingContext(FacebookDelegate<IGetCurrentGamingContextResult> callback)
		{
		}

		protected override void SetShareDialogMode(ShareDialogMode mode)
		{
		}

		private static IAndroidWrapper GetAndroidWrapper()
		{
			return null;
		}

		private void CallFB(string method, string args)
		{
		}
	}
}
