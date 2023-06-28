using DG.Tweening;
using GJG.Ingame.Marketing;
using Obi;
using UnityEngine;

public class SyringeActor : MonoBehaviour
{
	[SerializeField]
	private GameObject baseModels;

	[SerializeField]
	private GameObject base2Models;

	public Transform RayTarget;

	public GameObject Syringe;

	public GameObject DyeMesh;

	public GameObject PistonMesh;

	public ParticleSystem StickParticle;

	public ObiCollider ObiCollider;

	public SpriteRenderer ProgressBar;

	public Material ProgressBarFill;

	public AnimationCurve StickAnimCurve;

	public AnimationCurve PullAnimCurve;

	public bool IsActive;

	public float DyeAmount;

	public LevelColor _currentLevelColor;

	protected float _inputPieceTimer;

	protected float _inputTimer;

	protected float _dyeTimer;

	protected float _syringeAnimTimer;

	protected bool _isTapped;

	protected bool _isMovable;

	protected bool _isPickedColorRecently;

	protected bool _isDying;

	protected bool _isAutoFillStarted;

	protected bool _isStartDyeAnimStarted;

	protected bool _isInputOnPiece;

	protected bool _isParticlePlayed;

	protected Vector3 _lastPosition;

	protected Vector3 _startPosition;

	protected Vector3 _lastInputPosition;

	protected Vector3 _screenBounds;

	protected Quaternion _initialRotation;

	protected Vector3 _rayHitPosition;

	protected Vector2 _rayUVPosition;

	protected Collider _rayHitCollider;

	protected FluidSimulation _fluidSimulation;

	protected Camera _cam;

	public Color _currentColor;

	protected Sequence _activeAnim;

	public float BumpUvMultiplier;

	public float StickMoment;

	public float Stiff;

	public float Damp;

	public float Power;

	private int pickedParticleIndex;

	private MarketingPiece _marketingPiece;

	protected void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public virtual void Update()
	{
	}

	private void RotateSyringe()
	{
	}

	private void SyringeAnim()
	{
	}

	private void AnimateParticle()
	{
	}

	public void OnInputDown(Vector2 pos)
	{
	}

	public void OnInput(Vector2 pos)
	{
	}

	public virtual void OnInputUp(Vector2 pos)
	{
	}

	protected virtual void Move()
	{
	}

	protected void StartDying()
	{
	}

	protected virtual void StartContinousHaptic()
	{
	}

	protected virtual void StopDying()
	{
	}

	protected virtual void CheckFillAgain()
	{
	}

	protected virtual void DyeUpdate()
	{
	}

	protected virtual void UpdateHaptic()
	{
	}

	protected virtual void Splat(Vector2 direction, float force, float radius)
	{
	}

	public void StartAutoFill()
	{
	}

	public void PickColor(ColorActor colorActor, bool isTapped = false)
	{
	}

	public virtual void UpdateDyeAmount()
	{
	}

	protected Vector3 GetInputWorldPosition()
	{
		return default(Vector3);
	}

	public virtual void OnLevelStart(Material startMaterial)
	{
	}

	public void SetColor(LevelColor lc)
	{
	}

	public virtual void ResetData()
	{
	}

	public virtual void OnPieceFall()
	{
	}

	public void ShootStickButtonRay()
	{
	}

	public void OnLevelEnd()
	{
	}

	public void PickUIColor(LevelColor data, bool haptic = true)
	{
	}

	public void OnStickButton()
	{
	}

	public void OnStickButtonUp()
	{
	}
}
