using System;
using System.Collections.Generic;
using UnityEngine;

namespace Obi
{
	[Serializable]
	public class ObiStretchShearConstraintsBatch : ObiConstraintsBatch, IStructuralConstraintBatch
	{
		protected IStretchShearConstraintsBatchImpl m_BatchImpl;

		[HideInInspector]
		public ObiNativeIntList orientationIndices;

		[HideInInspector]
		public ObiNativeFloatList restLengths;

		[HideInInspector]
		public ObiNativeQuaternionList restOrientations;

		[HideInInspector]
		public ObiNativeVector3List stiffnesses;

		public override Oni.ConstraintType constraintType => default(Oni.ConstraintType);

		public override IConstraintsBatchImpl implementation => null;

		public ObiStretchShearConstraintsBatch(ObiStretchShearConstraintsData constraints = null)
		{
		}

		public void AddConstraint(Vector2Int indices, int orientationIndex, float restLength, Quaternion restOrientation)
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
