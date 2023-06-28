using Coffee.UIExtensions;
using DG.Tweening;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UI.Extensions;

public class UIVIPOffer : UIElement
{
	public static bool ISVIPpanelActive;

	public Animator SyringeAnimator;

	public UIParticleSystem ParticleSystem;

	public Camera ModelCam;

	public UIShiny BuyButton;

	private Sequence _moveSeq;

	private Sequence _buttonScaleSeq;

	public RectTransform Infographic;

	public RawImage SyringeVision;

	public Sprite WackyBuySprite;

	public Sprite VipButtonSprite1;

	public Sprite VipButtonSprite2;

	public Sprite VipButtonSprite3;

	public Sprite VipButtonSprite4;

	public override void Activate()
	{
	}

	public override void Deactivate()
	{
	}

	private void StartButtonAnim()
	{
	}

	[Button]
	private void StartSyringeAnim()
	{
	}

	public void OnBuyButton()
	{
	}

	public void OnRestorePurchase()
	{
	}

	public void OnPrivacyButton()
	{
	}

	public void OnTermsButton()
	{
	}
}
