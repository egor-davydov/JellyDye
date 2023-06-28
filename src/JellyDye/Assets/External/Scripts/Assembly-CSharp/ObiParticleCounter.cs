using System.Collections.Generic;
using Obi;
using UnityEngine;

public class ObiParticleCounter : MonoBehaviour
{
	private ObiSolver solver;

	public int counter;

	public Collider2D targetCollider;

	private ObiSolver.ObiCollisionEventArgs frame;

	private HashSet<int> particles;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void Solver_OnCollision(object sender, ObiSolver.ObiCollisionEventArgs e)
	{
	}
}
