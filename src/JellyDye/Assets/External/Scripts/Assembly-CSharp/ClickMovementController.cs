using UnityEngine;

public class ClickMovementController : MonoBehaviour
{
	public AnimationCurve SyringePenetrationCurve;

	private readonly Vector3 InitialRotation;

	private readonly Vector3 PenetratedRotation;

	private float holdTimer;

	private Vector3 InitialPosition;

	private bool isMovable;

	[SerializeField]
	private float animationSpeed;

	private void OnEnable()
	{
	}

	public void Activate()
	{
	}

	private void Update()
	{
	}

	private void UpdateZPosAndRotation()
	{
	}
}
