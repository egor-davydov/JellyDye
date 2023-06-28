using System.Collections.Generic;

namespace Facebook.Unity.Example
{
	internal sealed class MainMenu : MenuBase
	{
		private enum Scope
		{
			PublicProfile = 1,
			UserFriends = 2,
			UserBirthday = 3,
			UserAgeRange = 4,
			PublishActions = 5,
			UserLocation = 6,
			UserHometown = 7,
			UserGender = 8
		}

		protected override bool ShowBackButton()
		{
			return false;
		}

		protected override void GetGui()
		{
		}

		private void CallFBLogin(LoginTracking mode, HashSet<Scope> scope)
		{
		}

		private void CallFBLoginForPublish()
		{
		}

		private void CallFBLogout()
		{
		}

		private void OnInitComplete()
		{
		}

		private void OnHideUnity(bool isGameShown)
		{
		}
	}
}
