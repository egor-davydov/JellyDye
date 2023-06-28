using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UITutorial : UIElement
{
	public Image BackgroundImage;

	public Button NextButton;

	public Animator Anim;

	public GameObject Popup;

	public GameObject Tutorial1;

	public GameObject Tutorial2;

	public TextMeshProUGUI ButtonText;

	public TextMeshProUGUI TitleText;

	private float _timer;

	private int _progress;

	private bool _isActive;

	public override void Activate()
	{
	}

	public override void Deactivate()
	{
	}

	public void Pop()
	{
	}

	private void Update()
	{
	}

	public void OnNextButton()
	{
	}
}
