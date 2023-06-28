using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Facebook.Unity.Windows
{
	internal sealed class WindowsFacebook : FacebookBase, IWindowsFacebookImplementation, IWindowsFacebook, IPayFacebook, IFacebook, IFacebookWindows, IFacebookResultHandler
	{
		private string appId;

		private IWindowsWrapper windowsWrapper;

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

		public override string SDKName => null;

		public override string SDKVersion => null;

		public override bool LoggedIn => false;

		public WindowsFacebook()
			: base(null)
		{
		}

		public WindowsFacebook(IWindowsWrapper windowsWrapper, CallbackManager callbackManager)
			: base(null)
		{
		}

		public void Init(string appId, string clientToken, HideUnityDelegate hideUnityDelegate, InitDelegate onInitComplete)
		{
		}

		public override void LogInWithPublishPermissions(IEnumerable<string> scope, FacebookDelegate<ILoginResult> callback)
		{
		}

		public override void LogInWithReadPermissions(IEnumerable<string> scope, FacebookDelegate<ILoginResult> callback)
		{
		}

		public override void LogOut()
		{
		}

		public override void ActivateApp(string appId = null)
		{
		}

		public override void AppEventsLogEvent(string logEvent, float? valueToSum, Dictionary<string, object> parameters)
		{
		}

		public override void AppEventsLogPurchase(float logPurchase, string currency, Dictionary<string, object> parameters)
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

		public override void ConsumePurchase(string productToken, FacebookDelegate<IConsumePurchaseResult> callback)
		{
		}

		public override void CurrentProfile(FacebookDelegate<IProfileResult> callback)
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

		public override void OpenFriendFinderDialog(FacebookDelegate<IGamingServicesFriendFinderResult> callback)
		{
		}

		public override void GetFriendFinderInvitations(FacebookDelegate<IFriendFinderInvitationResult> callback)
		{
		}

		public override void DeleteFriendFinderInvitation(string invitationId, FacebookDelegate<IFriendFinderInvitationResult> callback)
		{
		}

		public override void ScheduleAppToUserNotification(string title, string body, Uri media, int timeInterval, string payload, FacebookDelegate<IScheduleAppToUserNotificationResult> callback)
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

		public new void UploadImageToMediaLibrary(string caption, Uri imageUri, bool shouldLaunchMediaDialog, string travelId, FacebookDelegate<IMediaUploadResult> callback)
		{
		}

		public new void UploadVideoToMediaLibrary(string caption, Uri videoUri, bool shouldLaunchMediaDialog, string travelId, FacebookDelegate<IMediaUploadResult> callback)
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

		private static IWindowsWrapper GetWindowsWrapper()
		{
			return null;
		}

		public void Tick()
		{
		}

		public void Deinit()
		{
		}

		public void SetVirtualGamepadLayout(string layout, FacebookDelegate<IVirtualGamepadLayoutResult> callback)
		{
		}

		public void SetSoftKeyboardOpen(bool open, FacebookDelegate<ISoftKeyboardOpenResult> callback)
		{
		}

		public override void AppRequest(string message, OGActionType? actionType, string objectId, IEnumerable<string> to, IEnumerable<object> filters, IEnumerable<string> excludeIds, int? maxRecipients, string data, string title, FacebookDelegate<IAppRequestResult> callback)
		{
		}

		public override void OnAppRequestsComplete(ResultContainer resultContainer)
		{
		}

		public override void OnLoginComplete(ResultContainer resultContainer)
		{
		}

		public override void FeedShare(string toId, Uri link, string linkName, string linkCaption, string linkDescription, Uri picture, string mediaSource, FacebookDelegate<IShareResult> callback)
		{
		}

		public override void ShareLink(Uri contentURL, string contentTitle, string contentDescription, Uri photoURL, FacebookDelegate<IShareResult> callback)
		{
		}

		public override void GetAppLink(FacebookDelegate<IAppLinkResult> callback)
		{
		}

		public override void OnShareLinkComplete(ResultContainer resultContainer)
		{
		}

		public override void OnGetAppLinkComplete(ResultContainer resultContainer)
		{
		}

		public void Pay(string product, string action, int quantity, int? quantityMin, int? quantityMax, string requestId, string pricepointId, string testCurrency, FacebookDelegate<IPayResult> callback)
		{
		}

		public override Profile CurrentProfile()
		{
			return null;
		}
	}
}
