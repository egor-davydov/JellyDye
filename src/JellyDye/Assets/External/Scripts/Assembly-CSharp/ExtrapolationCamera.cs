using UnityEngine;

public class ExtrapolationCamera : MonoBehaviour
{
	public Transform target;

	public float extrapolation;

	public float smoothness;

	public float linearSpeed;

	public float rotationalSpeed;

	public float distanceFromTarget;

	private Vector3 lastPosition;

	private Vector3 extrapolatedPos;

	private void Start()
	{
	}

	private void FixedUpdate()
	{
	}

	private void LateUpdate()
	{
	}

	public void Teleport(Vector3 position, Quaternion rotation)
	{
	}
}
