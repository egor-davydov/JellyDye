using UnityEngine;
using UnityEngine.UI;

public class StickButton : MonoSingleton<StickButton>
{
	public Image Button;

	public Sprite ButtonActive;

	public Sprite EpicButtonActive;

	public Sprite ButtonNotActive;

	public Sprite ButtonPressed;

	public Sprite EpicButtonPressed;

	public bool IsActive;

	public bool IsButtonPressed;

	private bool _isEpic;

	private Vector3 _startPos;

	private void Start()
	{
	}

	public void OnInputDown()
	{
	}

	public void OnInputUp()
	{
	}

	public void OnLevelStart()
	{
	}

	public void OnPiece(bool checkButton = true)
	{
	}

	public void OffPiece()
	{
	}

	public void OnEpicFillUnlocked()
	{
	}

	public StickButton()
	{
		((MonoSingleton<>)(object)this)._002Ector();
	}
}
