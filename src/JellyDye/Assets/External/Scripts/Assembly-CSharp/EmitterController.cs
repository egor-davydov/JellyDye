using System.Collections.Generic;
using UnityEngine;

public class EmitterController : MonoBehaviour
{
	public List<GameObject> emittersParent;

	public float velocity;

	public float strength;

	public float emitterScale;

	public GameObject emitterTarget;

	public Vector3 offsetEmitter;

	private void Awake()
	{
	}

	public void SetEmittersTarget(List<GameObject> targetObjects)
	{
	}

	public void EmitterAngle(float angle)
	{
	}

	public void SetVelocity(float tempVelocity)
	{
	}

	private void Update()
	{
	}

	public void ActivateEmitter()
	{
	}

	public void DeActivateEmitter()
	{
	}

	public void DestroyOldEmitters()
	{
	}
}
