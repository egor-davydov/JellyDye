using System.Collections.Generic;

namespace Facebook.Unity.Mobile
{
	internal interface IMobileFacebook : IFacebook, IFacebookWindows
	{
		ShareDialogMode ShareDialogMode { set; }

		void LoginWithTrackingPreference(string tracking, IEnumerable<string> permissions, string nonce, FacebookDelegate<ILoginResult> callback);

		void FetchDeferredAppLink(FacebookDelegate<IAppLinkResult> callback);

		void RefreshCurrentAccessToken(FacebookDelegate<IAccessTokenRefreshResult> callback);

		bool IsImplicitPurchaseLoggingEnabled();

		void OnIAPReady(FacebookDelegate<IIAPReadyResult> callback);

		void InitCloudGame(FacebookDelegate<IInitCloudGameResult> callback);

		void GameLoadComplete(FacebookDelegate<IGameLoadCompleteResult> callback);

		void GetPayload(FacebookDelegate<IPayloadResult> callback);

		void GetTournaments(FacebookDelegate<IGetTournamentsResult> callback);

		void UpdateTournament(string tournamentID, int score, FacebookDelegate<ITournamentScoreResult> callback);

		void UpdateAndShareTournament(string tournamentID, int score, FacebookDelegate<IDialogResult> callback);

		void CreateAndShareTournament(int initialScore, string title, TournamentSortOrder sortOrder, TournamentScoreFormat scoreFormat, long endTime, string payload, FacebookDelegate<IDialogResult> callback);

		void OpenAppStore(FacebookDelegate<IOpenAppStoreResult> callback);

		void CreateGamingContext(string playerID, FacebookDelegate<ICreateGamingContextResult> callback);

		void SwitchGamingContext(string gamingContextID, FacebookDelegate<ISwitchGamingContextResult> callback);

		void ChooseGamingContext(List<string> filters, int minSize, int maxSize, FacebookDelegate<IChooseGamingContextResult> callback);

		void GetCurrentGamingContext(FacebookDelegate<IGetCurrentGamingContextResult> callback);
	}
}
