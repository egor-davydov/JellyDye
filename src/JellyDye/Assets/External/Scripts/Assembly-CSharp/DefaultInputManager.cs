using UnityEngine;

public class DefaultInputManager : InputManager
{
	private bool _hasCatchedOnInputDown;

	public void Update()
	{
	}

	private void InputControl()
	{
	}

	private Vector2 GetInputPosition()
	{
		return default(Vector2);
	}

	public override void OnInput(Vector2 pos)
	{
	}

	public override void OnInputDown(Vector2 pos)
	{
	}

	public override void OnInputUp(Vector2 pos)
	{
	}
}
