using TMPro;
using UnityEngine;

namespace GGI.UI.IDFAOptin
{
	public class IDFAOptinPopupType14 : MonoBehaviour
	{
		public TextMeshProUGUI TitleText;

		public TextMeshProUGUI DescText;

		public RectTransform DefaultTopImage;

		public RectTransform WarningImage;

		public RectTransform OldImage;

		public TextMeshProUGUI OptionYesText;

		public TextMeshProUGUI OptionNoText;

		public RectTransform OptionYesButton;

		public RectTransform OptionNoButton;

		private bool _moreInfoTransitioned;

		public void Refresh()
		{
		}

		public void OnClickedYes()
		{
		}

		public void OnClickedNo()
		{
		}

		private void SetTexts(long textId = -1L)
		{
		}
	}
}
