using TMPro;
using UnityEngine;

namespace GGI.UI.IDFAOptin
{
	public class IDFAOptinPopupType13 : MonoBehaviour
	{
		public TextMeshProUGUI TitleText;

		public TextMeshProUGUI DescText;

		public TextMeshProUGUI OptionNoText;

		public TextMeshProUGUI OptionYesText;

		public RectTransform OptionYesButton;

		public RectTransform OptionNoButton;

		public RectTransform CatIcon;

		public RectTransform WarningIcon;

		public RectTransform GamesIcon;

		private bool _moreInfoTransitioned;

		public void OnClickedYes()
		{
		}

		public void OnClickedNo()
		{
		}

		public void Refresh()
		{
		}

		private void SetTexts(long textId = -1L)
		{
		}
	}
}
