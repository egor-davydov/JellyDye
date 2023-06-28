using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

namespace GGI.UI.GDPR
{
	public class UIDeleteGDPR : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
	{
		public TextMeshProUGUI TitleText;

		public TextMeshProUGUI DescText;

		public TextMeshProUGUI BackButtonText;

		public bool AdsConsent;

		public bool AnalyticsConsent;

		public void OnPointerClick(PointerEventData eventData)
		{
		}

		private void Start()
		{
		}

		public void OnClose()
		{
		}
	}
}
