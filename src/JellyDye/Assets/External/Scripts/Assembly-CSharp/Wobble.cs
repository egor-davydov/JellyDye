using UnityEngine;

public class Wobble : MonoBehaviour
{
	private Renderer rend;

	private Vector3 lastPos;

	private Vector3 velocity;

	private Vector3 lastRot;

	private Vector3 angularVelocity;

	public float MaxWobble;

	public float WobbleSpeed;

	public float Recovery;

	private float wobbleAmountX;

	private float wobbleAmountZ;

	private float wobbleAmountToAddX;

	private float wobbleAmountToAddZ;

	private float pulse;

	private float time;

	private void Start()
	{
	}

	private void Update()
	{
	}
}
