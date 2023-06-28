using TMPro;
using UnityEngine;

namespace GGI.UI.GDPR
{
	public class UIDidNotSharePanelGDPR : MonoBehaviour
	{
		public bool AdConsentGiven;

		public bool AnalyticConsentGiven;

		public bool IsForFirstConsent;

		public TextMeshProUGUI TitleText;

		public TextMeshProUGUI DescText;

		public TextMeshProUGUI BackButtonText;

		public TextMeshProUGUI ConfirmText;

		private void Start()
		{
		}

		public void OnCancelButtonClicked()
		{
		}

		public void OnAcceptButtonClicked()
		{
		}
	}
}
