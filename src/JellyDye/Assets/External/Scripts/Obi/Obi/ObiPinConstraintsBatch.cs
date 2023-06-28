using System;
using System.Collections.Generic;
using UnityEngine;

namespace Obi
{
	[Serializable]
	public class ObiPinConstraintsBatch : ObiConstraintsBatch
	{
		protected IPinConstraintsBatchImpl m_BatchImpl;

		[HideInInspector]
		public List<ObiColliderHandle> pinBodies;

		[HideInInspector]
		public ObiNativeIntList colliderIndices;

		[HideInInspector]
		public ObiNativeVector4List offsets;

		[HideInInspector]
		public ObiNativeQuaternionList restDarbouxVectors;

		[HideInInspector]
		public ObiNativeFloatList stiffnesses;

		[HideInInspector]
		public ObiNativeFloatList breakThresholds;

		public override Oni.ConstraintType constraintType => default(Oni.ConstraintType);

		public override IConstraintsBatchImpl implementation => null;

		public ObiPinConstraintsBatch(ObiPinConstraintsData constraints = null)
		{
		}

		public void AddConstraint(int solverIndex, ObiColliderBase body, Vector3 offset, Quaternion restDarboux, float linearCompliance, float rotationalCompliance, float breakThreshold)
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
