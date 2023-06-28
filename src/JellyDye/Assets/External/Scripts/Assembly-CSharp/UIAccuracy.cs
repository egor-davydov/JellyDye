using Coffee.UIExtensions;
using DG.Tweening;
using Sirenix.OdinInspector;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIAccuracy : UIElement
{
	public ParticleSystem BlueBallsParticle;

	public GameObject Popup;

	public RawImage CompletedImage;

	public RawImage RefImage;

	public Image RewardImage;

	public Image NextButton;

	public Image ProgressFill;

	public Image RewardedProgressFill;

	public UIShiny RewardedButton;

	public TextMeshProUGUI AccuracyText;

	public CanvasGroup CanvasGroup;

	private Sequence _rewardedFillSeq;

	private Sequence _rewardedScaleSeq;

	private float _currentProgress;

	private bool _isProgressFilled;

	private float _popUpScale;

	private void Start()
	{
	}

	[Button]
	public override void Activate()
	{
	}

	private void CheckReward()
	{
	}

	public void OnRewarded()
	{
	}

	private void GetMoreAccuracy()
	{
	}

	public override void Deactivate()
	{
	}
}
