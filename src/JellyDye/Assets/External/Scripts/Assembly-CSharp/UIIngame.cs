using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIIngame : UIElement
{
	public TextMeshProUGUI LevelText;

	public TextMeshProUGUI AccuracyLevelText;

	public Image HoldToInjectImage;

	public RawImage AccuracyRefImage;

	public Image AccuracyRefHolder;

	public Image NoAdsButton;

	public Image RestartButton;

	public Image NextButton;

	public Image NextButton2;

	public Image NextButton3;

	public Image EpicFillButton;

	public StickButton StickButton;

	private CanvasGroup _canvasGroup;

	private List<string> _dyedNames;

	private bool _isNextButtonShowing;

	private bool _isLevelEnded;

	private Sequence _activateSeq;

	private void Awake()
	{
	}

	private void MoPubManagerOnRewardedVideoLoadedEvent(string obj, MaxSdkBase.AdInfo adInfo)
	{
	}

	private void Start()
	{
	}

	public override void Activate()
	{
	}

	public override void Deactivate()
	{
	}

	public void OnLevelStart(int levelId)
	{
	}

	private void ShowEpicFillButton()
	{
	}

	public void OnEpicFillButton()
	{
	}

	public void OnFirstDye(string name)
	{
	}

	public void OnNextButton()
	{
	}

	public void OnChangeToolButton()
	{
	}

	public void OnGalleryButton()
	{
	}

	public void OnNoAdsButton()
	{
	}

	public void OnNoAds()
	{
	}

	public void OnRestart()
	{
	}

	public void OnStickButton()
	{
	}
}
