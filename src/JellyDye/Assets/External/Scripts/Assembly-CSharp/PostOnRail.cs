using UnityEngine;

public class PostOnRail : MonoBehaviour
{
	public Vector3 startPoint;

	public Vector3 endPoint;

	public float speed;

	public float wait;

	public float stabilization;

	public bool initialDirection;

	private float direction;

	private void Awake()
	{
	}

	private void FixedUpdate()
	{
	}

	private void OnDrawGizmosSelected()
	{
	}
}
