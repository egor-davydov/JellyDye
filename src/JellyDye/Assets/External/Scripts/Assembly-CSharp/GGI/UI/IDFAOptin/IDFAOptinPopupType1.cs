using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace GGI.UI.IDFAOptin
{
	public class IDFAOptinPopupType1 : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
	{
		public enum BackgroundSizeMode
		{
			Full = 0,
			ButtonWide = 1,
			Zero = 2
		}

		public RectTransform BackgroundTop;

		public RectTransform BackgroundBottom;

		public RectTransform BackgroundFull;

		public TextMeshProUGUI TitleText;

		public TextMeshProUGUI DescText;

		public TextMeshProUGUI YesButton;

		public Image YesButtonOverlay;

		public TextMeshProUGUI NoButton;

		public Image PopupBackgroundImage;

		public Image Seperator1;

		public Image Seperator2;

		public Image EmojiYes;

		public Image EmojiNo;

		public Image WinkEmoji;

		public Image ArrowsLeft;

		public Image ArrowsRight;

		public CanvasGroup CanvasGroup;

		public Button XButton;

		public Image Hand;

		public Image QuestionIcon;

		public Sprite IconCow;

		public Sprite IconEarth;

		public Sprite IconAppleVAndroid;

		public Sprite IconFlag;

		public Sprite IconRose;

		public Sprite IconViolet;

		public Sprite IconSugar;

		public Sprite IconHeart;

		public ParticleSystem ConfettiParticle;

		public ParticleSystem EmojiParticle;

		public Sprite HappyEmojiSprite;

		public Sprite PensiveEmojiSprite;

		public Sprite YoutubeIconSprite;

		private bool _hasXButton;

		private float _xButtonTimer;

		private long _xButtonWaitSeconds;

		private bool _xButtonTimerRunOut;

		private Vector3 _initialYesButtonPos;

		private Vector3 _initialNoButtonPos;

		private Sequence _handSeq;

		private bool _multipleMode;

		private int _currentMultipleIndex;

		private bool _multipleQuestionMode;

		private bool _multipleQuestionSingleChoiceMode;

		private int _currentQuestionModeIndex;

		private bool _multipleSwitched;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void Update()
		{
		}

		public void OnOptionYes()
		{
		}

		public void OnPopupNo()
		{
		}

		public void OnClickedX()
		{
		}

		public void OnPointerClick(PointerEventData eventData)
		{
		}

		public void Refresh()
		{
		}

		private void SetBackgroundSizes(BackgroundSizeMode mode)
		{
		}

		private void SetBackgroundColors(float t)
		{
		}

		private void AnimateHand()
		{
		}

		private void AnimateCanvasGroup()
		{
		}

		private void SetTexts(long textId = -1L)
		{
		}

		private void PlayEmojiParticles(bool option)
		{
		}

		private bool SetIcon(string text)
		{
			return false;
		}
	}
}
