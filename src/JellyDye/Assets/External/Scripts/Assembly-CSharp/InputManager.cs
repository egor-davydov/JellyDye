using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class InputManager : MonoSingleton<InputManager>
{
	public bool IsInputDisabled;

	public event Action<Vector2> InputEvent
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action<Vector2> InputDownEvent
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action<Vector2> InputUpEvent
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public virtual void OnInput(Vector2 pos)
	{
	}

	public virtual void OnInputDown(Vector2 pos)
	{
	}

	public virtual void OnInputUp(Vector2 pos)
	{
	}

	public bool IsOverUiElement()
	{
		return false;
	}

	public InputManager()
	{
		((MonoSingleton<>)(object)this)._002Ector();
	}
}
