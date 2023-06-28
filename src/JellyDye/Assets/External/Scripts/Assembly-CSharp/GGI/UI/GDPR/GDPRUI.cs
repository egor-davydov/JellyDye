using GGI.Components;
using UnityEngine;

namespace GGI.UI.GDPR
{
	public class GDPRUI : AutoSingletonMono<GDPRUI>
	{
		public UIInitialGDPR InitialScreen;

		public UIWarningGDPR WarningScreen;

		public UISupportBannerGDPR SupportBanner;

		public UIDidNotSharePanelGDPR LastScreen;

		public UISettingsPanelGDPR SettingsPanelOff;

		public UISettingsPanelGDPROn SettingsPanelOn;

		public UIDeleteGDPR DeletePanel;

		private Canvas _canvas;

		protected override void Awake()
		{
		}

		private void OnEnable()
		{
		}

		public void ActivateLearnMoreScreen()
		{
		}

		public void ActivateWarningScreen(bool adOption, bool analyticOption, bool isForFirstConsent)
		{
		}

		public void ActivateSettingsPanel()
		{
		}

		public void ActivateInitialScreen()
		{
		}

		public void ActivateConsentScreen()
		{
		}

		public void ActivatePartnersPanel(bool toAnalytics)
		{
		}

		public void ActivatePopup(string title, string desc)
		{
		}

		public void ActivateLastScreen(bool adConsent, bool analyticsConsent)
		{
		}

		public void ShowPopup(string title, string desc)
		{
		}

		public void DeactivateAllScreens()
		{
		}

		public void ActivateAccessModifyScreen(bool adsConsent, bool analyticsConsent)
		{
		}

		public void ActivateDeleteScreen()
		{
		}

		public void ActivateSupportBanner()
		{
		}

		public void ActivateFirstConsentScreen()
		{
		}

		public GDPRUI()
		{
			((AutoSingletonMono<>)(object)this)._002Ector();
		}
	}
}
