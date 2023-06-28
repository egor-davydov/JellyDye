using UnityEngine;
using UnityEngine.Events;

public class FluidEmitter : MonoBehaviour
{
	public bool _isMoved;

	public GameObject RayChild;

	public Color Color;

	private bool isEmitterActive;

	public UnityAction CheckEmitterActive;

	public FluidSimulation fluidSimulation;

	private Vector3 raycastDir;

	private void Start()
	{
	}

	private Color GenerateColor()
	{
		return default(Color);
	}

	public void ActivateEmitter()
	{
	}

	public void DeActivateEmitter()
	{
	}

	public void ChangedColor(Color changedColor)
	{
	}

	private void Update()
	{
	}
}
