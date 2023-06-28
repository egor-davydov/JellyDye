using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace GGI.UI.IDFAOptin
{
	public class IDFAOptinPopupType10 : MonoBehaviour
	{
		public TextMeshProUGUI TitleText;

		public TextMeshProUGUI DescText;

		public TextMeshProUGUI OptionYesText;

		public TextMeshProUGUI OptionNoText;

		public Sprite YoutubeIcon;

		public Sprite WarningIcon;

		public Image LogoImage;

		public Image EmojiYes;

		public Image EmojiNo;

		private bool _multipleMode;

		private int _currentMultipleIndex;

		private void Start()
		{
		}

		public void OnOptionYes()
		{
		}

		public void OnOptionNo()
		{
		}

		public void TransitionToMultipleIndex(int index, long textId)
		{
		}

		public void Refresh()
		{
		}

		private void PlaceEmojiButtons()
		{
		}

		private void SetTexts(long textId = -1L)
		{
		}
	}
}
