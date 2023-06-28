using System;
using System.Collections.Generic;

namespace Facebook.Unity.Mobile
{
	internal abstract class MobileFacebook : FacebookBase, IMobileFacebookImplementation, IMobileFacebook, IFacebook, IFacebookWindows, IMobileFacebookResultHandler, IFacebookResultHandler
	{
		private ShareDialogMode shareDialogMode;

		public ShareDialogMode ShareDialogMode
		{
			set
			{
			}
		}

		protected MobileFacebook(CallbackManager callbackManager)
			: base(null)
		{
		}

		public abstract AuthenticationToken CurrentAuthenticationToken();

		public override Profile CurrentProfile()
		{
			return null;
		}

		public override void CurrentProfile(FacebookDelegate<IProfileResult> callback)
		{
		}

		public abstract void LoginWithTrackingPreference(string tracking, IEnumerable<string> permissions, string nonce, FacebookDelegate<ILoginResult> callback);

		public abstract void FetchDeferredAppLink(FacebookDelegate<IAppLinkResult> callback);

		public abstract void RefreshCurrentAccessToken(FacebookDelegate<IAccessTokenRefreshResult> callback);

		public abstract bool IsImplicitPurchaseLoggingEnabled();

		public override void OnLoginComplete(ResultContainer resultContainer)
		{
		}

		public override void OnGetAppLinkComplete(ResultContainer resultContainer)
		{
		}

		public override void OnAppRequestsComplete(ResultContainer resultContainer)
		{
		}

		public void OnFetchDeferredAppLinkComplete(ResultContainer resultContainer)
		{
		}

		public override void OnShareLinkComplete(ResultContainer resultContainer)
		{
		}

		public void OnRefreshCurrentAccessTokenComplete(ResultContainer resultContainer)
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

		public void OnTournamentDialogError(ResultContainer resultContainer)
		{
		}

		public void OnTournamentDialogCancel(ResultContainer resultContainer)
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

		public override void UploadImageToMediaLibrary(string caption, Uri imageUri, bool shouldLaunchMediaDialog, FacebookDelegate<IMediaUploadResult> callback)
		{
		}

		public override void UploadVideoToMediaLibrary(string caption, Uri videoUri, bool shouldLaunchMediaDialog, FacebookDelegate<IMediaUploadResult> callback)
		{
		}

		public virtual void OnIAPReady(FacebookDelegate<IIAPReadyResult> callback)
		{
		}

		public override void GetCatalog(FacebookDelegate<ICatalogResult> callback)
		{
		}

		public override void GetPurchases(FacebookDelegate<IPurchasesResult> callback)
		{
		}

		public override void Purchase(string productID, FacebookDelegate<IPurchaseResult> callback, string developerPayload)
		{
		}

		public override void ConsumePurchase(string purchaseToken, FacebookDelegate<IConsumePurchaseResult> callback)
		{
		}

		public virtual void InitCloudGame(FacebookDelegate<IInitCloudGameResult> callback)
		{
		}

		public virtual void GameLoadComplete(FacebookDelegate<IGameLoadCompleteResult> callback)
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

		public virtual void GetPayload(FacebookDelegate<IPayloadResult> callback)
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

		public virtual void GetTournaments(FacebookDelegate<IGetTournamentsResult> callback)
		{
		}

		public virtual void UpdateTournament(string tournamentID, int score, FacebookDelegate<ITournamentScoreResult> callback)
		{
		}

		public virtual void UpdateAndShareTournament(string tournamentID, int score, FacebookDelegate<IDialogResult> callback)
		{
		}

		public virtual void CreateAndShareTournament(int initialScore, string title, TournamentSortOrder sortOrder, TournamentScoreFormat scoreFormat, long endTime, string payload, FacebookDelegate<IDialogResult> callback)
		{
		}

		public virtual void OpenAppStore(FacebookDelegate<IOpenAppStoreResult> callback)
		{
		}

		public virtual void CreateGamingContext(string playerID, FacebookDelegate<ICreateGamingContextResult> callback)
		{
		}

		public virtual void SwitchGamingContext(string gamingContextID, FacebookDelegate<ISwitchGamingContextResult> callback)
		{
		}

		public virtual void ChooseGamingContext(List<string> filters, int minSize, int maxSize, FacebookDelegate<IChooseGamingContextResult> callback)
		{
		}

		public virtual void GetCurrentGamingContext(FacebookDelegate<IGetCurrentGamingContextResult> callback)
		{
		}

		protected abstract void SetShareDialogMode(ShareDialogMode mode);
	}
}
