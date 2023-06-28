using System;
using System.Collections.Generic;
using UnityEngine;

namespace Obi
{
	[Serializable]
	public class ObiVolumeConstraintsBatch : ObiConstraintsBatch
	{
		protected IVolumeConstraintsBatchImpl m_BatchImpl;

		[HideInInspector]
		public ObiNativeIntList firstTriangle;

		[HideInInspector]
		public ObiNativeIntList numTriangles;

		[HideInInspector]
		public ObiNativeFloatList restVolumes;

		[HideInInspector]
		public ObiNativeVector2List pressureStiffness;

		public override Oni.ConstraintType constraintType => default(Oni.ConstraintType);

		public override IConstraintsBatchImpl implementation => null;

		public ObiVolumeConstraintsBatch(ObiVolumeConstraintsData constraints = null)
		{
		}

		public void AddConstraint(int[] triangles, float restVolume)
		{
		}

		public override void Clear()
		{
		}

		public override void GetParticlesInvolved(int index, List<int> particles)
		{
		}

		protected override void SwapConstraints(int sourceIndex, int destIndex)
		{
		}

		public override void Merge(ObiActor actor, IObiConstraintsBatch other)
		{
		}

		public override void AddToSolver(ObiSolver solver)
		{
		}

		public override void RemoveFromSolver(ObiSolver solver)
		{
		}

		public void SetParameters(float compliance, float pressure)
		{
		}
	}
}
