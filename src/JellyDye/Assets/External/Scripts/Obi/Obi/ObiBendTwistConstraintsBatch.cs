using System;
using System.Collections.Generic;
using UnityEngine;

namespace Obi
{
	[Serializable]
	public class ObiBendTwistConstraintsBatch : ObiConstraintsBatch
	{
		protected IBendTwistConstraintsBatchImpl m_BatchImpl;

		[HideInInspector]
		public ObiNativeQuaternionList restDarbouxVectors;

		[HideInInspector]
		public ObiNativeVector3List stiffnesses;

		public override Oni.ConstraintType constraintType => default(Oni.ConstraintType);

		public override IConstraintsBatchImpl implementation => null;

		public ObiBendTwistConstraintsBatch(ObiBendTwistConstraintsData constraints = null)
		{
		}

		public void AddConstraint(Vector2Int indices, Quaternion restDarboux)
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
