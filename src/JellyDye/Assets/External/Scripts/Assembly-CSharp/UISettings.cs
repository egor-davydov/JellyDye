using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class UISettings : UIElement
{
	public Image VibrationKnobImage;

	public Image VibrationImage;

	public Image AudioKnobImage;

	public Image AudioImage;

	private Tween _inputTween;

	public Sprite OnSprite;

	public Sprite OffSprite;

	public override void Activate()
	{
	}

	public override void Deactivate()
	{
	}

	public void OnRestorePurchase()
	{
	}

	public void ToggleVibration()
	{
	}

	public void ToggleAudio()
	{
	}

	public void OnPrivacyPolicyButton()
	{
	}
}
