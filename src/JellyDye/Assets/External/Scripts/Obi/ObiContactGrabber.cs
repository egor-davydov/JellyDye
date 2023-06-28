using System.Collections.Generic;
using Obi;
using UnityEngine;

public class ObiContactGrabber : MonoBehaviour
{
	private class GrabbedParticle : IEqualityComparer<GrabbedParticle>
	{
		public int index;

		public float invMass;

		public Vector3 localPosition;

		public ObiSolver solver;

		public GrabbedParticle(ObiSolver solver, int index, float invMass)
		{
		}

		public bool Equals(GrabbedParticle x, GrabbedParticle y)
		{
			return false;
		}

		public int GetHashCode(GrabbedParticle obj)
		{
			return 0;
		}
	}

	public ObiSolver[] solvers;

	private Dictionary<ObiSolver, ObiSolver.ObiCollisionEventArgs> collisionEvents;

	private ObiCollider localCollider;

	private HashSet<GrabbedParticle> grabbedParticles;

	private HashSet<ObiActor> grabbedActors;

	public bool grabbed => false;

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

	private void UpdateParticleProperties()
	{
	}

	private bool GrabParticle(ObiSolver solver, int index)
	{
		return false;
	}

	public void Grab()
	{
	}

	public void Release()
	{
	}

	private void FixedUpdate()
	{
	}
}
