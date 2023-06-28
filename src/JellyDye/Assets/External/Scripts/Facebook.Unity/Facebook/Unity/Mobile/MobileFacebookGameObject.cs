namespace Facebook.Unity.Mobile
{
	internal abstract class MobileFacebookGameObject : FacebookGameObject, IFacebookCallbackHandler
	{
		private IMobileFacebookImplementation MobileFacebook => null;

		public void OnFetchDeferredAppLinkComplete(string message)
		{
		}

		public void OnRefreshCurrentAccessTokenComplete(string message)
		{
		}

		public void OnFriendFinderComplete(string message)
		{
		}

		public void OnUploadImageToMediaLibraryComplete(string message)
		{
		}

		public void OnUploadVideoToMediaLibraryComplete(string message)
		{
		}

		public void OnOnIAPReadyComplete(string message)
		{
		}

		public void OnGetCatalogComplete(string message)
		{
		}

		public void OnGetPurchasesComplete(string message)
		{
		}

		public void OnPurchaseComplete(string message)
		{
		}

		public void OnConsumePurchaseComplete(string message)
		{
		}

		public void OnInitCloudGameComplete(string message)
		{
		}

		public void OnGameLoadCompleteComplete(string message)
		{
		}

		public void OnScheduleAppToUserNotificationComplete(string message)
		{
		}

		public void OnLoadInterstitialAdComplete(string message)
		{
		}

		public void OnShowInterstitialAdComplete(string message)
		{
		}

		public void OnLoadRewardedVideoComplete(string message)
		{
		}

		public void OnShowRewardedVideoComplete(string message)
		{
		}

		public void OnGetPayloadComplete(string message)
		{
		}

		public virtual void OnPostSessionScoreComplete(string message)
		{
		}

		public virtual void OnPostTournamentScoreComplete(string message)
		{
		}

		public virtual void OnGetTournamentComplete(string message)
		{
		}

		public virtual void OnShareTournamentComplete(string message)
		{
		}

		public virtual void OnCreateTournamentComplete(string message)
		{
		}

		public virtual void OnGetTournamentsComplete(string message)
		{
		}

		public virtual void OnUpdateTournamentComplete(string message)
		{
		}

		public virtual void OnTournamentDialogSuccess(string message)
		{
		}

		public virtual void OnTournamentDialogCancel(string message)
		{
		}

		public virtual void OnTournamentDialogError(string message)
		{
		}

		public void OnOpenAppStoreComplete(string message)
		{
		}

		public void OnCreateGamingContextComplete(string message)
		{
		}

		public void OnSwitchGamingContextComplete(string message)
		{
		}

		public void OnChooseGamingContextComplete(string message)
		{
		}

		public void OnGetCurrentGamingContextComplete(string message)
		{
		}
	}
}
