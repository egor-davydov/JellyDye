using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace GGI.UI.IDFAOptin
{
	public class IDFAOptinPopupType11 : MonoBehaviour
	{
		public TextMeshProUGUI TitleText;

		public TextMeshProUGUI DescText;

		public Image ProgressBarImage;

		public RectTransform Stick;

		public TextMeshProUGUI ProgressBarText;

		public TextMeshProUGUI ButtonText;

		public RectTransform Hand;

		public RectTransform DiamondIcon;

		private Sequence _handSeq;

		private Sequence _diamondSeq;

		private Tween _progressTween;

		private Tween _stickTween;

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

		public void Refresh()
		{
		}

		private void UpdateProgressBar()
		{
		}

		private void AnimateHand()
		{
		}

		private void AnimateDiamond()
		{
		}

		private void SetTexts(int textId = -1)
		{
		}
	}
}
