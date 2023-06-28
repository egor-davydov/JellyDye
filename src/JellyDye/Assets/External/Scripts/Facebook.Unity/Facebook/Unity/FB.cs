using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Facebook.Unity.Mobile;
using Facebook.Unity.Windows;
using UnityEngine;

namespace Facebook.Unity
{
	public sealed class FB : ScriptableObject
	{
		private delegate void OnDLLLoaded();

		public sealed class Canvas
		{
			private static IPayFacebook FacebookPayImpl => null;

			public static void Pay(string product, string action = "purchaseitem", int quantity = 1, int? quantityMin = null, int? quantityMax = null, string requestId = null, string pricepointId = null, string testCurrency = null, FacebookDelegate<IPayResult> callback = null)
			{
			}
		}

		public sealed class Mobile
		{
			public static ShareDialogMode ShareDialogMode
			{
				set
				{
				}
			}

			private static IMobileFacebook MobileFacebookImpl => null;

			public static void LoginWithTrackingPreference(LoginTracking loginTracking, IEnumerable<string> permissions = null, string nonce = null, FacebookDelegate<ILoginResult> callback = null)
			{
			}

			public static Profile CurrentProfile()
			{
				return null;
			}

			public static void FetchDeferredAppLinkData(FacebookDelegate<IAppLinkResult> callback = null)
			{
			}

			public static void RefreshCurrentAccessToken(FacebookDelegate<IAccessTokenRefreshResult> callback = null)
			{
			}

			public static bool IsImplicitPurchaseLoggingEnabled()
			{
				return false;
			}

			public static void GetTournaments(FacebookDelegate<IGetTournamentsResult> callback)
			{
			}

			public static void UpdateTournament(string tournamentID, int score, FacebookDelegate<ITournamentScoreResult> callback)
			{
			}

			public static void UpdateAndShareTournament(string tournamentID, int score, FacebookDelegate<IDialogResult> callback)
			{
			}

			public static void CreateAndShareTournament(int initialScore, string title, TournamentSortOrder sortOrder, TournamentScoreFormat scoreFormat, DateTime endTime, string payload, FacebookDelegate<IDialogResult> callback)
			{
			}

			public static void UploadImageToMediaLibrary(string caption, Uri imageUri, bool shouldLaunchMediaDialog, FacebookDelegate<IMediaUploadResult> callback)
			{
			}

			public static void UploadVideoToMediaLibrary(string caption, Uri videoUri, bool shouldLaunchMediaDialog, FacebookDelegate<IMediaUploadResult> callback)
			{
			}
		}

		public sealed class Windows
		{
			private static IWindowsFacebook WindowsFacebookImpl => null;

			public static void SetVirtualGamepadLayout(string layout, FacebookDelegate<IVirtualGamepadLayoutResult> callback)
			{
			}

			public static void SetSoftKeyboardOpen(bool open, FacebookDelegate<ISoftKeyboardOpenResult> callback)
			{
			}
		}

		internal abstract class CompiledFacebookLoader : MonoBehaviour
		{
			protected abstract FacebookGameObject FBGameObject { get; }

			public void Start()
			{
			}
		}

		private const string DefaultJSSDKLocale = "en_US";

		private static IFacebook facebook;

		private static bool isInitCalled;

		private static string facebookDomain;

		private static string gamingDomain;

		private static string graphApiVersion;

		public static string AppId
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

		public static string ClientToken
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

		public static string GraphApiVersion
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static bool IsLoggedIn => false;

		public static bool IsInitialized => false;

		public static bool LimitAppEventUsage
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		internal static IFacebook FacebookImpl
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal static string FacebookDomain
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private static OnDLLLoaded OnDLLLoadedDelegate
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public static void Init(InitDelegate onInitComplete = null, HideUnityDelegate onHideUnity = null, string authResponse = null)
		{
		}

		public static void Init(string appId, string clientToken = null, bool cookie = true, bool logging = true, bool status = true, bool xfbml = false, bool frictionlessRequests = true, string authResponse = null, string javascriptSDKLocale = "en_US", HideUnityDelegate onHideUnity = null, InitDelegate onInitComplete = null)
		{
		}

		public static void LogInWithPublishPermissions(IEnumerable<string> permissions = null, FacebookDelegate<ILoginResult> callback = null)
		{
		}

		public static void LogInWithReadPermissions(IEnumerable<string> permissions = null, FacebookDelegate<ILoginResult> callback = null)
		{
		}

		public static void LogOut()
		{
		}

		public static void AppRequest(string message, OGActionType actionType, string objectId, IEnumerable<string> to, string data = "", string title = "", FacebookDelegate<IAppRequestResult> callback = null)
		{
		}

		public static void AppRequest(string message, OGActionType actionType, string objectId, IEnumerable<object> filters = null, IEnumerable<string> excludeIds = null, int? maxRecipients = null, string data = "", string title = "", FacebookDelegate<IAppRequestResult> callback = null)
		{
		}

		public static void AppRequest(string message, IEnumerable<string> to = null, IEnumerable<object> filters = null, IEnumerable<string> excludeIds = null, int? maxRecipients = null, string data = "", string title = "", FacebookDelegate<IAppRequestResult> callback = null)
		{
		}

		public static void ShareLink(Uri contentURL = null, string contentTitle = "", string contentDescription = "", Uri photoURL = null, FacebookDelegate<IShareResult> callback = null)
		{
		}

		public static void FeedShare(string toId = "", Uri link = null, string linkName = "", string linkCaption = "", string linkDescription = "", Uri picture = null, string mediaSource = "", FacebookDelegate<IShareResult> callback = null)
		{
		}

		public static void API(string query, HttpMethod method, FacebookDelegate<IGraphResult> callback = null, IDictionary<string, string> formData = null)
		{
		}

		public static void API(string query, HttpMethod method, FacebookDelegate<IGraphResult> callback, WWWForm formData)
		{
		}

		public static void ActivateApp()
		{
		}

		public static void GetAppLink(FacebookDelegate<IAppLinkResult> callback)
		{
		}

		public static void ClearAppLink()
		{
		}

		public static void LogAppEvent(string logEvent, float? valueToSum = null, Dictionary<string, object> parameters = null)
		{
		}

		public static void LogPurchase(decimal logPurchase, string currency = null, Dictionary<string, object> parameters = null)
		{
		}

		public static void LogPurchase(float logPurchase, string currency = null, Dictionary<string, object> parameters = null)
		{
		}

		private static void LogVersion()
		{
		}

		public static void GetCatalog(FacebookDelegate<ICatalogResult> callback)
		{
		}

		public static void GetPurchases(FacebookDelegate<IPurchasesResult> callback)
		{
		}

		public static void Purchase(string productID, FacebookDelegate<IPurchaseResult> callback, string developerPayload = "")
		{
		}

		public static void ConsumePurchase(string productToken, FacebookDelegate<IConsumePurchaseResult> callback)
		{
		}

		public static Profile CurrentProfile()
		{
			return null;
		}

		public static void CurrentProfile(FacebookDelegate<IProfileResult> callback)
		{
		}

		public static void LoadInterstitialAd(string placementID, FacebookDelegate<IInterstitialAdResult> callback)
		{
		}

		public static void ShowInterstitialAd(string placementID, FacebookDelegate<IInterstitialAdResult> callback)
		{
		}

		public static void LoadRewardedVideo(string placementID, FacebookDelegate<IRewardedVideoResult> callback)
		{
		}

		public static void ShowRewardedVideo(string placementID, FacebookDelegate<IRewardedVideoResult> callback)
		{
		}

		public static void OpenFriendFinderDialog(FacebookDelegate<IGamingServicesFriendFinderResult> callback)
		{
		}

		public static void GetFriendFinderInvitations(FacebookDelegate<IFriendFinderInvitationResult> callback)
		{
		}

		public static void DeleteFriendFinderInvitation(string invitationId, FacebookDelegate<IFriendFinderInvitationResult> callback)
		{
		}

		public static void ScheduleAppToUserNotification(string title, string body, Uri media, int timeInterval, string payload, FacebookDelegate<IScheduleAppToUserNotificationResult> callback)
		{
		}

		public static void PostSessionScore(int score, FacebookDelegate<ISessionScoreResult> callback)
		{
		}

		public static void PostTournamentScore(int score, FacebookDelegate<ITournamentScoreResult> callback)
		{
		}

		public static void GetTournament(FacebookDelegate<ITournamentResult> callback)
		{
		}

		public static void ShareTournament(int score, Dictionary<string, string> data, FacebookDelegate<ITournamentScoreResult> callback)
		{
		}

		public static void CreateTournament(int initialScore, string title, string imageBase64DataUrl, string sortOrder, string scoreFormat, Dictionary<string, string> data, FacebookDelegate<ITournamentResult> callback)
		{
		}

		public static void UploadImageToMediaLibrary(string caption, Uri imageUri, bool shouldLaunchMediaDialog, FacebookDelegate<IMediaUploadResult> callback)
		{
		}

		public static void UploadVideoToMediaLibrary(string caption, Uri videoUri, bool shouldLaunchMediaDialog, FacebookDelegate<IMediaUploadResult> callback)
		{
		}

		public static void UploadImageToMediaLibrary(string caption, Uri imageUri, bool shouldLaunchMediaDialog, string travelId, FacebookDelegate<IMediaUploadResult> callback)
		{
		}

		public static void UploadVideoToMediaLibrary(string caption, Uri videoUri, bool shouldLaunchMediaDialog, string travelId, FacebookDelegate<IMediaUploadResult> callback)
		{
		}

		public static void GetUserLocale(FacebookDelegate<ILocaleResult> callback)
		{
		}
	}
}
