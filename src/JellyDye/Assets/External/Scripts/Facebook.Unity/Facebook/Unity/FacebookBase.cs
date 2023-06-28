using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Facebook.Unity
{
	internal abstract class FacebookBase : IFacebookImplementation, IFacebook, IFacebookWindows, IFacebookResultHandler
	{
		private InitDelegate onInitCompleteDelegate;

		public abstract bool LimitEventUsage { get; set; }

		public abstract string SDKName { get; }

		public abstract string SDKVersion { get; }

		public virtual string SDKUserAgent => null;

		public virtual bool LoggedIn => false;

		public bool Initialized
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

		protected CallbackManager CallbackManager
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		protected FacebookBase(CallbackManager callbackManager)
		{
		}

		public virtual void Init(InitDelegate onInitComplete)
		{
		}

		public abstract void LogInWithPublishPermissions(IEnumerable<string> scope, FacebookDelegate<ILoginResult> callback);

		public abstract void LogInWithReadPermissions(IEnumerable<string> scope, FacebookDelegate<ILoginResult> callback);

		public virtual void LogOut()
		{
		}

		public abstract void AppRequest(string message, OGActionType? actionType, string objectId, IEnumerable<string> to, IEnumerable<object> filters, IEnumerable<string> excludeIds, int? maxRecipients, string data, string title, FacebookDelegate<IAppRequestResult> callback);

		public abstract void ShareLink(Uri contentURL, string contentTitle, string contentDescription, Uri photoURL, FacebookDelegate<IShareResult> callback);

		public abstract void FeedShare(string toId, Uri link, string linkName, string linkCaption, string linkDescription, Uri picture, string mediaSource, FacebookDelegate<IShareResult> callback);

		public void API(string query, HttpMethod method, IDictionary<string, string> formData, FacebookDelegate<IGraphResult> callback)
		{
		}

		public void API(string query, HttpMethod method, WWWForm formData, FacebookDelegate<IGraphResult> callback)
		{
		}

		public abstract void ActivateApp(string appId = null);

		public abstract void GetAppLink(FacebookDelegate<IAppLinkResult> callback);

		public abstract void AppEventsLogEvent(string logEvent, float? valueToSum, Dictionary<string, object> parameters);

		public abstract void AppEventsLogPurchase(float logPurchase, string currency, Dictionary<string, object> parameters);

		public virtual void OnInitComplete(ResultContainer resultContainer)
		{
		}

		public abstract void OnLoginComplete(ResultContainer resultContainer);

		public void OnLogoutComplete(ResultContainer resultContainer)
		{
		}

		public abstract void OnGetAppLinkComplete(ResultContainer resultContainer);

		public abstract void OnAppRequestsComplete(ResultContainer resultContainer);

		public abstract void OnShareLinkComplete(ResultContainer resultContainer);

		protected void ValidateAppRequestArgs(string message, OGActionType? actionType, string objectId, IEnumerable<string> to = null, IEnumerable<object> filters = null, IEnumerable<string> excludeIds = null, int? maxRecipients = null, string data = "", string title = "", FacebookDelegate<IAppRequestResult> callback = null)
		{
		}

		protected virtual void OnAuthResponse(LoginResult result)
		{
		}

		private IDictionary<string, string> CopyByValue(IDictionary<string, string> data)
		{
			return null;
		}

		private Uri GetGraphUrl(string query)
		{
			return null;
		}

		public abstract void GetCatalog(FacebookDelegate<ICatalogResult> callback);

		public abstract void GetPurchases(FacebookDelegate<IPurchasesResult> callback);

		public abstract void Purchase(string productID, FacebookDelegate<IPurchaseResult> callback, string developerPayload = "");

		public abstract void ConsumePurchase(string productToken, FacebookDelegate<IConsumePurchaseResult> callback);

		public abstract Profile CurrentProfile();

		public abstract void CurrentProfile(FacebookDelegate<IProfileResult> callback);

		public abstract void LoadInterstitialAd(string placementID, FacebookDelegate<IInterstitialAdResult> callback);

		public abstract void ShowInterstitialAd(string placementID, FacebookDelegate<IInterstitialAdResult> callback);

		public abstract void LoadRewardedVideo(string placementID, FacebookDelegate<IRewardedVideoResult> callback);

		public abstract void ShowRewardedVideo(string placementID, FacebookDelegate<IRewardedVideoResult> callback);

		public abstract void OpenFriendFinderDialog(FacebookDelegate<IGamingServicesFriendFinderResult> callback);

		public abstract void GetFriendFinderInvitations(FacebookDelegate<IFriendFinderInvitationResult> callback);

		public abstract void DeleteFriendFinderInvitation(string invitationId, FacebookDelegate<IFriendFinderInvitationResult> callback);

		public abstract void ScheduleAppToUserNotification(string title, string body, Uri media, int timeInterval, string payload, FacebookDelegate<IScheduleAppToUserNotificationResult> callback);

		public abstract void PostSessionScore(int score, FacebookDelegate<ISessionScoreResult> callback);

		public abstract void PostTournamentScore(int score, FacebookDelegate<ITournamentScoreResult> callback);

		public abstract void GetTournament(FacebookDelegate<ITournamentResult> callback);

		public abstract void ShareTournament(int score, Dictionary<string, string> data, FacebookDelegate<ITournamentScoreResult> callback);

		public abstract void CreateTournament(int initialScore, string title, string imageBase64DataUrl, string sortOrder, string scoreFormat, Dictionary<string, string> data, FacebookDelegate<ITournamentResult> callback);

		public abstract void UploadImageToMediaLibrary(string caption, Uri imageUri, bool shouldLaunchMediaDialog, FacebookDelegate<IMediaUploadResult> callback);

		public abstract void UploadVideoToMediaLibrary(string caption, Uri videoUri, bool shouldLaunchMediaDialog, FacebookDelegate<IMediaUploadResult> callback);

		public void UploadImageToMediaLibrary(string caption, Uri imageUri, bool shouldLaunchMediaDialog, string travelId, FacebookDelegate<IMediaUploadResult> callback)
		{
		}

		public void UploadVideoToMediaLibrary(string caption, Uri videoUri, bool shouldLaunchMediaDialog, string travelId, FacebookDelegate<IMediaUploadResult> callback)
		{
		}

		public abstract void GetUserLocale(FacebookDelegate<ILocaleResult> callback);
	}
}
