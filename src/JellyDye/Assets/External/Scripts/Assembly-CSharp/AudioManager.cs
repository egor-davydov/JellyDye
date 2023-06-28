using UnityEngine;

public class AudioManager : MonoSingleton<AudioManager>
{
	public AudioSource Fill;

	public AudioSource Refill;

	public AudioSource SlimeDrop;

	public AudioSource Click;

	public AudioSource StickOut;

	public AudioClip LongFillClip;

	private void Start()
	{
	}

	public void OnFill()
	{
	}

	public void OnReFill()
	{
	}

	public void OnSlimeDrop()
	{
	}

	public void OnClick()
	{
	}

	public void OnStickOut()
	{
	}

	public AudioManager()
	{
		((MonoSingleton<>)(object)this)._002Ector();
	}
}
