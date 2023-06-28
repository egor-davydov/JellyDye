using UnityEngine;
using UnityEngine.UI;

public abstract class UIElement : MonoBehaviour
{
	private Canvas canvas;

	private GraphicRaycaster raycaster;

	public virtual void Activate()
	{
	}

	public virtual void Deactivate()
	{
	}

	public void SetInputEnabled(bool enabled)
	{
	}

	private void ActivateCanvas()
	{
	}

	private void DeactivateCanvas()
	{
	}

	public bool IsCanvasActive()
	{
		return false;
	}
}
