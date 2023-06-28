using UnityEngine;
using UnityEngine.Events;

public class CyringePoint : MonoBehaviour
{
	[SerializeField]
	private float animationSpeed;

	private float holdTimer;

	private bool isMovable;

	private readonly Vector3 PenetrationOffset;

	public Vector3 Offset;

	private Vector3 screenPoint;

	public AnimationCurve SyringePenetrationCurve;

	public AnimationCurve SyringeReleaseCurve;

	private Vector3 curScreenPoint;

	private Vector3 curPosition;

	public bool isActiveCyringe;

	public float mouseButtonDownTime;

	public UnityAction ActivateEmitters;

	public UnityAction DeActivateEmitters;

	public UnityAction<float> EmitterAngle;

	public GameObject parent;

	public GameObject target;

	public GameObject display;

	private void OnEnable()
	{
	}

	public void Activate()
	{
	}

	private void Update()
	{
	}

	private void UpdatePosition()
	{
	}
}
