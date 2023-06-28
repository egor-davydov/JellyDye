using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace GGI.UI.IDFAOptin
{
	public class IDFAOptinPopupType12 : MonoBehaviour
	{
		public TextMeshProUGUI TitleText;

		public TextMeshProUGUI DescText;

		public TextMeshProUGUI ButtonText;

		public RectTransform Hand;

		private Sequence _handSeq;

		private Tween _progressTween;

		public Image ProgressBarImage;

		private int _clickCount;

		private float _currentProgress;

		private bool _hasDecreaseProgress;

		private void Start()
		{
		}

		private void Update()
		{
		}

		public void OnButtonClick()
		{
		}

		private void UpdateProgressBar()
		{
		}

		public void Refresh()
		{
		}

		private void AnimateHand()
		{
		}

		private void SetTexts(int textId = -1)
		{
		}
	}
}
