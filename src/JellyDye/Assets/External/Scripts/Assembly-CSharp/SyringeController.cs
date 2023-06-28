using GJG.Ingame;
using Obi;
using UnityEngine;
using UnityEngine.Events;

public class SyringeController : MonoBehaviour
{
	public bool isRotateActive;

	private Vector3 screenPoint;

	public Vector3 offset;

	public Vector3 lastPosition;

	public ObiCollider obiCollider;

	[SerializeField]
	private float animationSpeed;

	public AnimationCurve SyringePenetrationCurve;

	public AnimationCurve SyringeReleaseCurve;

	public SyringeAnimationController syringeAnimationController;

	private bool touchingObject;

	private Vector3 curPosition;

	private Vector3 curScreenPoint;

	public float holdTimer;

	private bool isFluidRemain;

	private float touchTime;

	public float touchTimeActivate;

	public float smoothTime;

	private Vector3 velocity;

	private bool animationActive;

	private bool isNeedleInside;

	public float defaultHeight;

	public float forwardValue;

	public float touchOffset;

	public GameObject target;

	public Renderer targetRenderer;

	public GameObject progressBar;

	public bool isRotatable;

	private bool colorFilling;

	private Ray ray;

	private RaycastHit hit;

	private Vector3 raycastDir;

	private Quaternion quaternion;

	public bool _isMoved;

	public GameObject RayChild;

	public Color color;

	private bool isEmitterActive;

	public UnityAction CheckEmitterActive;

	public UnityAction AutoFill;

	public FluidSimulation fluidSimulation;

	private float forceMultiplier;

	private float forceMultiplierButtonUp;

	public float emitterActiveTime;

	private bool autoFillCall;

	private Vector3 mouseFirst;

	private Vector3 mouseSecond;

	private Vector3 firstPosition;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void UpdatePosition()
	{
	}

	protected void RotateTowards(Vector3 from, Vector3 to)
	{
	}

	public void RotateActiveToggle()
	{
	}

	private void FluidUpdate()
	{
	}

	private void SyringeImmersionPosition()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void OnTriggerExit(Collider other)
	{
	}

	private void OnTriggerStay(Collider other)
	{
	}

	public bool ReturnIsFluidRemain()
	{
		return false;
	}

	public bool IsNeedleInside()
	{
		return false;
	}

	public void SyringeColliderActive()
	{
	}

	public void SyringeColliderDisable()
	{
	}

	public float ReturnRemainingFluid()
	{
		return 0f;
	}

	public void ColorFill(GameObject targetColorObject)
	{
	}

	public void ColorFillCompleted()
	{
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

	public void FillColor(Material mat)
	{
	}

	public Color ReturnCurrentColor()
	{
		return default(Color);
	}
}
