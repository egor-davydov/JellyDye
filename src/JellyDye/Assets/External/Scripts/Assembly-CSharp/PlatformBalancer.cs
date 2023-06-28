using UnityEngine;

public class PlatformBalancer : MonoBehaviour
{
	public float targetRotation;

	public float bias;

	public float Kp;

	public float Ki;

	public float Kd;

	private float lastIntegral;

	private float lastError;

	private HingeJoint joint;

	private void Awake()
	{
	}

	private void FixedUpdate()
	{
	}
}
