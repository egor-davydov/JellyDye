using DG.Tweening;
using Gjg.Io.GameConfig.Proto.Config.V3.Resources;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace GGI.UI.IDFAOptin
{
	public class IDFAOptinPopupType2 : MonoBehaviour
	{
		public TextMeshProUGUI TitleText;

		public TextMeshProUGUI DescText;

		public TextMeshProUGUI YesButton;

		public TextMeshProUGUI NoButton;

		public Button XButton;

		public Button NoButtonButton;

		public CanvasGroup CanvasGroup;

		public Sprite NonStylizedBackgroundSprite;

		public Sprite NonStylizedIconSprite;

		public Sprite NonStylizedButtonSprite;

		public Sprite StylizedBackgroundSprite;

		public Sprite StylizedIconSprite;

		public Sprite StylizedButtonSprite;

		public Image BackgroundImage;

		public Image TopIconImage;

		public Image ButtonImage;

		public Image Hand;

		public Image ThumbsUpEmoji;

		public Image PensiveEmoji;

		public ParticleSystem ConfettiParticle;

		public ParticleSystem EmojiParticle;

		public GameObject Overlay;

		public Sprite HappyEmojiSprite;

		public Sprite PensiveEmojiSprite;

		public Image WinkEmoji;

		private bool _hasTransitioned;

		private bool _hasXButton;

		private float _xButtonTimer;

		private long _xButtonWaitSeconds;

		private bool _xButtonTimerRunOut;

		private Sequence _handSeq;

		public Optin OptinConfig => null;

		public string TestIdentifier => null;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void Update()
		{
		}

		public void Refresh()
		{
		}

		public void OnOptionYes()
		{
		}

		public void OnOptionNo()
		{
		}

		public void OnXButtonClick()
		{
		}

		private void AnimateHand()
		{
		}

		private void PlayEmojiParticles(bool option)
		{
		}

		private void SetTexts()
		{
		}
	}
}
