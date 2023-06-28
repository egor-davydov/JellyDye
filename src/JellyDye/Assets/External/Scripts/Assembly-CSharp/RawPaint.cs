using UnityEngine;
using UnityEngine.Events;

public class RawPaint : MonoBehaviour
{
	public ColorType ColorType;

	public Gradient m_colourGradient;

	public UnityAction<Gradient> ColorChange;

	private void OnTriggerStay(Collider other)
	{
	}

	private void OnTriggerExit(Collider other)
	{
	}
}
