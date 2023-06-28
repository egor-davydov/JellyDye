using System;
using System.Collections.Generic;
using UnityEngine;

namespace Obi
{
	[Serializable]
	public class ObiDistanceConstraintsBatch : ObiConstraintsBatch, IStructuralConstraintBatch
	{
		[NonSerialized]
		protected IDistanceConstraintsBatchImpl m_BatchImpl;

		[HideInInspector]
		public ObiNativeFloatList restLengths;

		[HideInInspector]
		public ObiNativeVector2List stiffnesses;

		public override Oni.ConstraintType constraintType => default(Oni.ConstraintType);

		public override IConstraintsBatchImpl implementation => null;

		public ObiDistanceConstraintsBatch(int a = 0)
		{
		}

		public void AddConstraint(Vector2Int indices, float restLength)
		{
		}

		public override void Clear()
		{
		}

		public float GetRestLength(int index)
		{
			return 0f;
		}

		public void SetRestLength(int index, float restLength)
		{
		}

		public ParticlePair GetParticleIndices(int index)
		{
			return default(ParticlePair);
		}

		public override void GetParticlesInvolved(int index, List<int> particles)
		{
		}

		protected override void CopyConstraint(ObiConstraintsBatch batch, int constraintIndex)
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
