using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Facebook.Unity.Canvas;
using Facebook.Unity.Mobile;

namespace Facebook.Unity.Editor
{
	internal class EditorFacebook : FacebookBase, IMobileFacebookImplementation, IMobileFacebook, IFacebook, IFacebookWindows, IMobileFacebookResultHandler, IFacebookResultHandler, ICanvasFacebookImplementation, IPayFacebook, ICanvasFacebookResultHandler
	{
		private IEditorWrapper editorWrapper;

		public override bool LimitEventUsage
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public ShareDialogMode ShareDialogMode
		{
			[CompilerGenerated]
			set
			{
			}
		}

		public override string SDKName => null;

		public override string SDKVersion => null;

		private static IFacebookCallbackHandler EditorGameObject => null;

		public EditorFacebook(IEditorWrapper wrapper, CallbackManager callbackManager)
			: base(null)
		{
		}

		public EditorFacebook()
			: base(null)
		{
		}

		public override void Init(InitDelegate onInitComplete)
		{
		}

		public override void LogInWithReadPermissions(IEnumerable<string> permissions, FacebookDelegate<ILoginResult> callback)
		{
		}

		public override void LogInWithPublishPermissions(IEnumerable<string> permissions, FacebookDelegate<ILoginResult> callback)
		{
		}

		public void LoginWithTrackingPreference(string tracking, IEnumerable<string> permissions, string nonce, FacebookDelegate<ILoginResult> callback)
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

		public override void ActivateApp(string appId)
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

		public bool IsImplicitPurchaseLoggingEnabled()
		{
			return false;
		}

		public override Profile CurrentProfile()
		{
			return null;
		}

		public override void CurrentProfile(FacebookDelegate<IProfileResult> callback)
		{
		}

		public void FetchDeferredAppLink(FacebookDelegate<IAppLinkResult> callback)
		{
		}

		public void Pay(string product, string action, int quantity, int? quantityMin, int? quantityMax, string requestId, string pricepointId, string testCurrency, FacebookDelegate<IPayResult> callback)
		{
		}

		public void RefreshCurrentAccessToken(FacebookDelegate<IAccessTokenRefreshResult> callback)
		{
		}

		public override void OnAppRequestsComplete(ResultContainer resultContainer)
		{
		}

		public override void OnGetAppLinkComplete(ResultContainer resultContainer)
		{
		}

		public override void OnLoginComplete(ResultContainer resultContainer)
		{
		}

		public override void OnShareLinkComplete(ResultContainer resultContainer)
		{
		}

		public void OnFetchDeferredAppLinkComplete(ResultContainer resultContainer)
		{
		}

		public void OnPayComplete(ResultContainer resultContainer)
		{
		}

		public void OnRefreshCurrentAccessTokenComplete(ResultContainer resultContainer)
		{
		}

		public void OnFriendFinderComplete(ResultContainer resultContainer)
		{
		}

		public void OnUploadImageToMediaLibraryComplete(ResultContainer resultContainer)
		{
		}

		public void OnUploadVideoToMediaLibraryComplete(ResultContainer resultContainer)
		{
		}

		public void OnOnIAPReadyComplete(ResultContainer resultContainer)
		{
		}

		public void OnGetCatalogComplete(ResultContainer resultContainer)
		{
		}

		public void OnGetPurchasesComplete(ResultContainer resultContainer)
		{
		}

		public void OnPurchaseComplete(ResultContainer resultContainer)
		{
		}

		public void OnConsumePurchaseComplete(ResultContainer resultContainer)
		{
		}

		public void OnInitCloudGameComplete(ResultContainer resultContainer)
		{
		}

		public void OnGameLoadCompleteComplete(ResultContainer resultContainer)
		{
		}

		public void OnScheduleAppToUserNotificationComplete(ResultContainer resultContainer)
		{
		}

		public void OnLoadInterstitialAdComplete(ResultContainer resultContainer)
		{
		}

		public void OnShowInterstitialAdComplete(ResultContainer resultContainer)
		{
		}

		public void OnLoadRewardedVideoComplete(ResultContainer resultContainer)
		{
		}

		public void OnShowRewardedVideoComplete(ResultContainer resultContainer)
		{
		}

		public void OnGetPayloadComplete(ResultContainer resultContainer)
		{
		}

		public void OnPostSessionScoreComplete(ResultContainer resultContainer)
		{
		}

		public void OnPostTournamentScoreComplete(ResultContainer resultContainer)
		{
		}

		public void OnGetTournamentComplete(ResultContainer resultContainer)
		{
		}

		public void OnShareTournamentComplete(ResultContainer resultContainer)
		{
		}

		public void OnCreateTournamentComplete(ResultContainer resultContainer)
		{
		}

		public void OnGetTournamentsComplete(ResultContainer resultContainer)
		{
		}

		public void OnUpdateTournamentComplete(ResultContainer resultContainer)
		{
		}

		public void OnTournamentDialogSuccess(ResultContainer resultContainer)
		{
		}

		public void OnTournamentDialogCancel(ResultContainer resultContainer)
		{
		}

		public void OnTournamentDialogError(ResultContainer resultContainer)
		{
		}

		public void OnOpenAppStoreComplete(ResultContainer resultContainer)
		{
		}

		public void OnCreateGamingContextComplete(ResultContainer resultContainer)
		{
		}

		public void OnSwitchGamingContextComplete(ResultContainer resultContainer)
		{
		}

		public void OnChooseGamingContextComplete(ResultContainer resultContainer)
		{
		}

		public void OnGetCurrentGamingContextComplete(ResultContainer resultContainer)
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

		public override void UploadVideoToMediaLibrary(string caption, Uri imageUri, bool shouldLaunchMediaDialog, FacebookDelegate<IMediaUploadResult> callback)
		{
		}

		public override void GetUserLocale(FacebookDelegate<ILocaleResult> callback)
		{
		}

		public void OnIAPReady(FacebookDelegate<IIAPReadyResult> callback)
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

		public override void ConsumePurchase(string productID, FacebookDelegate<IConsumePurchaseResult> callback)
		{
		}

		public void InitCloudGame(FacebookDelegate<IInitCloudGameResult> callback)
		{
		}

		public void GameLoadComplete(FacebookDelegate<IGameLoadCompleteResult> callback)
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

		public void GetPayload(FacebookDelegate<IPayloadResult> callback)
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

		public override void ShareTournament(int score, Dictionary<string, string> data, FacebookDelegate<ITournamentScoreResult> callback)
		{
		}

		public override void CreateTournament(int initialScore, string title, string imageBase64DataUrl, string sortOrder, string scoreFormat, Dictionary<string, string> data, FacebookDelegate<ITournamentResult> callback)
		{
		}

		public void GetTournaments(FacebookDelegate<IGetTournamentsResult> callback)
		{
		}

		public void UpdateTournament(string tournamentID, int score, FacebookDelegate<ITournamentScoreResult> callback)
		{
		}

		public void UpdateAndShareTournament(string tournamentID, int score, FacebookDelegate<IDialogResult> callback)
		{
		}

		public void CreateAndShareTournament(int initialScore, string title, TournamentSortOrder sortOrder, TournamentScoreFormat scoreFormat, long endTime, string payload, FacebookDelegate<IDialogResult> callback)
		{
		}

		public void OpenAppStore(FacebookDelegate<IOpenAppStoreResult> callback)
		{
		}

		public void CreateGamingContext(string playerID, FacebookDelegate<ICreateGamingContextResult> callback)
		{
		}

		public void SwitchGamingContext(string gamingContextID, FacebookDelegate<ISwitchGamingContextResult> callback)
		{
		}

		public void ChooseGamingContext(List<string> filters, int minSize, int maxSize, FacebookDelegate<IChooseGamingContextResult> callback)
		{
		}

		public void GetCurrentGamingContext(FacebookDelegate<IGetCurrentGamingContextResult> callback)
		{
		}

		public void OnFacebookAuthResponseChange(ResultContainer resultContainer)
		{
		}

		public void OnUrlResponse(string message)
		{
		}

		public void OnHideUnity(bool hidden)
		{
		}
	}
}
