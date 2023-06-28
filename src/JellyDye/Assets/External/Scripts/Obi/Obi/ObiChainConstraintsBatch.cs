using System;
using System.Collections.Generic;
using UnityEngine;

namespace Obi
{
	[Serializable]
	public class ObiChainConstraintsBatch : ObiConstraintsBatch
	{
		protected IChainConstraintsBatchImpl m_BatchImpl;

		[HideInInspector]
		public ObiNativeIntList firstParticle;

		[HideInInspector]
		public ObiNativeIntList numParticles;

		[HideInInspector]
		public ObiNativeVector2List lengths;

		public override Oni.ConstraintType constraintType => default(Oni.ConstraintType);

		public override IConstraintsBatchImpl implementation => null;

		public ObiChainConstraintsBatch(ObiChainConstraintsData constraints = null)
		{
		}

		public void AddConstraint(int[] indices, float restLength, float stretchStiffness, float compressionStiffness)
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
	}
}
