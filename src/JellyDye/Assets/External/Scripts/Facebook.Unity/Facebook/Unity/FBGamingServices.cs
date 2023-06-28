using System;
using System.Collections.Generic;
using Facebook.Unity.Mobile;
using UnityEngine;

namespace Facebook.Unity
{
	public sealed class FBGamingServices : ScriptableObject
	{
		private static IMobileFacebook MobileFacebookImpl => null;

		public static void OpenFriendFinderDialog(FacebookDelegate<IGamingServicesFriendFinderResult> callback)
		{
		}

		public static void UploadImageToMediaLibrary(string caption, Uri imageUri, bool shouldLaunchMediaDialog, FacebookDelegate<IMediaUploadResult> callback)
		{
		}

		public static void UploadVideoToMediaLibrary(string caption, Uri videoUri, bool shouldLaunchMediaDialog, FacebookDelegate<IMediaUploadResult> callback)
		{
		}

		public static void PerformCustomUpdate(CustomUpdateContent content, FacebookDelegate<IGraphResult> callback = null)
		{
		}

		public static void OnIAPReady(FacebookDelegate<IIAPReadyResult> callback)
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

		public static void ConsumePurchase(string purchaseToken, FacebookDelegate<IConsumePurchaseResult> callback)
		{
		}

		public static void InitCloudGame(FacebookDelegate<IInitCloudGameResult> callback)
		{
		}

		public static void GameLoadComplete(FacebookDelegate<IGameLoadCompleteResult> callback)
		{
		}

		public static void ScheduleAppToUserNotification(string title, string body, Uri media, int timeInterval, string payload, FacebookDelegate<IScheduleAppToUserNotificationResult> callback)
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

		public static void GetPayload(FacebookDelegate<IPayloadResult> callback)
		{
		}

		public static void PostSessionScore(int score, FacebookDelegate<ISessionScoreResult> callback)
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

		public static void PostTournamentScore(int score, FacebookDelegate<ITournamentScoreResult> callback)
		{
		}

		public static void OpenAppStore(FacebookDelegate<IOpenAppStoreResult> callback)
		{
		}

		public static void CreateGamingContext(string playerID, FacebookDelegate<ICreateGamingContextResult> callback)
		{
		}

		public static void SwitchGamingContext(string gamingContextID, FacebookDelegate<ISwitchGamingContextResult> callback)
		{
		}

		public static void ChooseGamingContext(List<string> filters, int minSize, int maxSize, FacebookDelegate<IChooseGamingContextResult> callback)
		{
		}

		public static void GetCurrentGamingContext(FacebookDelegate<IGetCurrentGamingContextResult> callback)
		{
		}
	}
}
