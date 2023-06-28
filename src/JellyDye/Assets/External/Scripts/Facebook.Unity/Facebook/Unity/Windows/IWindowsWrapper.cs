using System;
using System.Collections.Generic;

namespace Facebook.Unity.Windows
{
	internal interface IWindowsWrapper
	{
		bool Init(string appId, string clientToken);

		void LogInWithScopes(IEnumerable<string> scope, string callbackId, CallbackManager callbackManager);

		bool IsLoggedIn();

		void LogOut();

		void Tick();

		void Deinit();

		void GetCatalog(string callbackId, CallbackManager callbackManager);

		void GetPurchases(string callbackId, CallbackManager callbackManager);

		void Purchase(string productID, string developerPayload, string callbackId, CallbackManager callbackManager);

		void ConsumePurchase(string productToken, string callbackId, CallbackManager callbackManager);

		void CurrentProfile(string callbackId, CallbackManager callbackManager);

		void LoadInterstitialAd(string placementID, string callbackId, CallbackManager callbackManager);

		void ShowInterstitialAd(string placementID, string callbackId, CallbackManager callbackManager);

		void LoadRewardedVideo(string placementID, string callbackId, CallbackManager callbackManager);

		void ShowRewardedVideo(string placementID, string callbackId, CallbackManager callbackManager);

		void OpenFriendFinderDialog(string callbackId, CallbackManager callbackManager);

		void GetFriendFinderInvitations(string callbackId, CallbackManager callbackManager);

		void DeleteFriendFinderInvitation(string invitationId, string callbackId, CallbackManager callbackManager);

		void ScheduleAppToUserNotification(string title, string body, Uri media, int timeInterval, string payload, string callbackId, CallbackManager callbackManager);

		void PostSessionScore(int score, string callbackId, CallbackManager callbackManager);

		void PostTournamentScore(int score, string callbackId, CallbackManager callbackManager);

		void GetTournament(string callbackId, CallbackManager callbackManager);

		void ShareTournament(int score, Dictionary<string, string> data, string callbackId, CallbackManager callbackManager);

		void CreateTournament(int initialScore, string title, string imageBase64DataUrl, string sortOrder, string scoreFormat, Dictionary<string, string> data, string callbackId, CallbackManager callbackManager);

		void UploadImageToMediaLibrary(string caption, Uri imageUri, bool shouldLaunchMediaDialog, string callbackId, string travelId, CallbackManager callbackManager);

		void UploadVideoToMediaLibrary(string caption, Uri videoUri, bool shouldLaunchMediaDialog, string callbackId, string travelId, CallbackManager callbackManager);

		void SetVirtualGamepadLayout(string layout, string callbackId, CallbackManager callbackManager);

		void GetUserLocale(string callbackId, CallbackManager callbackManager);

		void SetSoftKeyboardOpen(bool open, string callbackId, CallbackManager callbackManager);
	}
}
