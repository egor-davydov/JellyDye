using System;
using System.Collections.Generic;
using UnityEngine;

namespace Facebook.Unity
{
	internal interface IFacebook : IFacebookWindows
	{
		bool LoggedIn { get; }

		bool LimitEventUsage { get; set; }

		string SDKUserAgent { get; }

		bool Initialized { get; }

		void LogInWithPublishPermissions(IEnumerable<string> permissions, FacebookDelegate<ILoginResult> callback);

		void LogInWithReadPermissions(IEnumerable<string> permissions, FacebookDelegate<ILoginResult> callback);

		void LogOut();

		void AppRequest(string message, OGActionType? actionType, string objectId, IEnumerable<string> to, IEnumerable<object> filters, IEnumerable<string> excludeIds, int? maxRecipients, string data, string title, FacebookDelegate<IAppRequestResult> callback);

		void ShareLink(Uri contentURL, string contentTitle, string contentDescription, Uri photoURL, FacebookDelegate<IShareResult> callback);

		void FeedShare(string toId, Uri link, string linkName, string linkCaption, string linkDescription, Uri picture, string mediaSource, FacebookDelegate<IShareResult> callback);

		void API(string query, HttpMethod method, IDictionary<string, string> formData, FacebookDelegate<IGraphResult> callback);

		void API(string query, HttpMethod method, WWWForm formData, FacebookDelegate<IGraphResult> callback);

		void ActivateApp(string appId = null);

		void GetAppLink(FacebookDelegate<IAppLinkResult> callback);

		void AppEventsLogEvent(string logEvent, float? valueToSum, Dictionary<string, object> parameters);

		void AppEventsLogPurchase(float logPurchase, string currency, Dictionary<string, object> parameters);

		void GetCatalog(FacebookDelegate<ICatalogResult> callback);

		void GetPurchases(FacebookDelegate<IPurchasesResult> callback);

		void Purchase(string productID, FacebookDelegate<IPurchaseResult> callback, string developerPayload = "");

		void ConsumePurchase(string productToken, FacebookDelegate<IConsumePurchaseResult> callback);

		Profile CurrentProfile();

		void CurrentProfile(FacebookDelegate<IProfileResult> callback);

		void LoadInterstitialAd(string placementID, FacebookDelegate<IInterstitialAdResult> callback);

		void ShowInterstitialAd(string placementID, FacebookDelegate<IInterstitialAdResult> callback);

		void LoadRewardedVideo(string placementID, FacebookDelegate<IRewardedVideoResult> callback);

		void ShowRewardedVideo(string placementID, FacebookDelegate<IRewardedVideoResult> callback);

		void OpenFriendFinderDialog(FacebookDelegate<IGamingServicesFriendFinderResult> callback);

		void GetFriendFinderInvitations(FacebookDelegate<IFriendFinderInvitationResult> callback);

		void DeleteFriendFinderInvitation(string invitationId, FacebookDelegate<IFriendFinderInvitationResult> callback);

		void ScheduleAppToUserNotification(string title, string body, Uri media, int timeInterval, string payload, FacebookDelegate<IScheduleAppToUserNotificationResult> callback);

		void PostSessionScore(int score, FacebookDelegate<ISessionScoreResult> callback);

		void PostTournamentScore(int score, FacebookDelegate<ITournamentScoreResult> callback);

		void GetTournament(FacebookDelegate<ITournamentResult> callback);

		void ShareTournament(int score, Dictionary<string, string> data, FacebookDelegate<ITournamentScoreResult> callback);

		void CreateTournament(int initialScore, string title, string imageBase64DataUrl, string sortOrder, string scoreFormat, Dictionary<string, string> data, FacebookDelegate<ITournamentResult> callback);

		void UploadImageToMediaLibrary(string caption, Uri imageUri, bool shouldLaunchMediaDialog, FacebookDelegate<IMediaUploadResult> callback);

		void UploadVideoToMediaLibrary(string caption, Uri videoUri, bool shouldLaunchMediaDialog, FacebookDelegate<IMediaUploadResult> callback);

		void GetUserLocale(FacebookDelegate<ILocaleResult> callback);
	}
}
