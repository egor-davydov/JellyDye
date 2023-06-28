using Sirenix.OdinInspector;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIAccuracyNoProgress : UIElement
{
	public GameObject Popup;

	public RawImage CompletedImage;

	public RawImage RefImage;

	public Image NextButton;

	public Image ProgressFill;

	public TextMeshProUGUI AccuracyText;

	public CanvasGroup CanvasGroup;

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

	public override void Deactivate()
	{
	}
}
