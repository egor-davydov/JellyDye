using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

namespace GGI.UI.GDPR
{
	public class UISettingsPanelGDPROn : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
	{
		public TextMeshProUGUI TitleText;

		public TextMeshProUGUI DescText;

		public TextMeshProUGUI ButtonText;

		private bool _isHyperLinkClicked;

		public void OnPointerClick(PointerEventData eventData)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void OnHyperLinkClicked()
		{
		}

		public void OnSaveButtonClicked()
		{
		}
	}
}
