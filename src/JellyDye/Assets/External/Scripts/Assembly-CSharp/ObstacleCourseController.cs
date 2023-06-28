using Obi;
using UnityEngine;
using UnityEngine.Events;

public class ObstacleCourseController : MonoBehaviour
{
	private ObiSolver solver;

	public ObiSoftbody softbody;

	public ActorCOMTransform softbodyCOM;

	public ObiCollider deathPitCollider;

	public ObiCollider finishCollider;

	public Transform spawnPoint;

	public Transform cameraSpawnPoint;

	public UnityEvent onDeath;

	public UnityEvent onFinish;

	public UnityEvent onRestart;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void LateUpdate()
	{
	}

	private void Solver_OnCollision(ObiSolver s, ObiSolver.ObiCollisionEventArgs e)
	{
	}
}
