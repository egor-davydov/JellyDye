using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class MegaSoft2D
{
	public List<Mass2D> masses;

	public List<Spring2D> springs;

	public List<Constraint2D> constraints;

	public Vector2 gravity;

	public float airdrag;

	public float friction;

	public float timeStep;

	public int iters;

	public MegaIntegrator method;

	public bool applyConstraints;

	public float floor;

	public float lasttime;

	public float simtime;

	private void doCalculateForceseuler()
	{
	}

	private void doCalculateForces()
	{
	}

	private void doIntegration1(float dt)
	{
	}

	private void DoCollisions(float dt)
	{
	}

	private void VerletIntegrate(float t, float lastt)
	{
	}

	private void VerletIntegrateTC(float t, float lastt)
	{
	}

	private void MidPointIntegrate(float t)
	{
	}

	public void DoConstraints()
	{
	}

	public void Update()
	{
	}
}
