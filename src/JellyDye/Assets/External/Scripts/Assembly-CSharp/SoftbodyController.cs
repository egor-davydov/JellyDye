using Obi;
using UnityEngine;

public class SoftbodyController : MonoBehaviour
{
	public Transform referenceFrame;

	public float acceleration;

	public float jumpPower;

	public float airControl;

	private ObiSoftbody softbody;

	private bool onGround;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void Update()
	{
	}

	private void Solver_OnCollision(ObiSolver solver, ObiSolver.ObiCollisionEventArgs e)
	{
	}
}
