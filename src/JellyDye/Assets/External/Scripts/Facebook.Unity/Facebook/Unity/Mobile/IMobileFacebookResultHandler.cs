namespace Facebook.Unity.Mobile
{
	internal interface IMobileFacebookResultHandler : IFacebookResultHandler
	{
		void OnFetchDeferredAppLinkComplete(ResultContainer resultContainer);

		void OnRefreshCurrentAccessTokenComplete(ResultContainer resultContainer);

		void OnFriendFinderComplete(ResultContainer resultContainer);

		void OnUploadImageToMediaLibraryComplete(ResultContainer resultContainer);

		void OnUploadVideoToMediaLibraryComplete(ResultContainer resultContainer);

		void OnOnIAPReadyComplete(ResultContainer resultContainer);

		void OnGetCatalogComplete(ResultContainer resultContainer);

		void OnGetPurchasesComplete(ResultContainer resultContainer);

		void OnPurchaseComplete(ResultContainer resultContainer);

		void OnConsumePurchaseComplete(ResultContainer resultContainer);

		void OnInitCloudGameComplete(ResultContainer resultContainer);

		void OnGameLoadCompleteComplete(ResultContainer resultContainer);

		void OnScheduleAppToUserNotificationComplete(ResultContainer resultContainer);

		void OnLoadInterstitialAdComplete(ResultContainer resultContainer);

		void OnShowInterstitialAdComplete(ResultContainer resultContainer);

		void OnLoadRewardedVideoComplete(ResultContainer resultContainer);

		void OnShowRewardedVideoComplete(ResultContainer resultContainer);

		void OnGetPayloadComplete(ResultContainer resultContainer);

		void OnPostSessionScoreComplete(ResultContainer resultContainer);

		void OnGetTournamentComplete(ResultContainer resultContainer);

		void OnShareTournamentComplete(ResultContainer resultContainer);

		void OnCreateTournamentComplete(ResultContainer resultContainer);

		void OnPostTournamentScoreComplete(ResultContainer resultContainer);

		void OnGetTournamentsComplete(ResultContainer resultContainer);

		void OnUpdateTournamentComplete(ResultContainer resultContainer);

		void OnTournamentDialogSuccess(ResultContainer resultContainer);

		void OnTournamentDialogCancel(ResultContainer resultContainer);

		void OnTournamentDialogError(ResultContainer resultContainer);

		void OnOpenAppStoreComplete(ResultContainer resultContainer);

		void OnCreateGamingContextComplete(ResultContainer resultContainer);

		void OnSwitchGamingContextComplete(ResultContainer resultContainer);

		void OnChooseGamingContextComplete(ResultContainer resultContainer);

		void OnGetCurrentGamingContextComplete(ResultContainer resultContainer);
	}
}
