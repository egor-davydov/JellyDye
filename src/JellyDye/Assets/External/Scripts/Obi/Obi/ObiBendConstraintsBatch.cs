using System;
using System.Collections.Generic;
using UnityEngine;

namespace Obi
{
	[Serializable]
	public class ObiBendConstraintsBatch : ObiConstraintsBatch
	{
		protected IBendConstraintsBatchImpl m_BatchImpl;

		[HideInInspector]
		public ObiNativeFloatList restBends;

		[HideInInspector]
		public ObiNativeVector2List bendingStiffnesses;

		public override Oni.ConstraintType constraintType => default(Oni.ConstraintType);

		public override IConstraintsBatchImpl implementation => null;

		public ObiBendConstraintsBatch(ObiBendConstraintsData constraints = null)
		{
		}

		public override void Merge(ObiActor actor, IObiConstraintsBatch other)
		{
		}

		public void AddConstraint(Vector3Int indices, float restBend)
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

		public override void AddToSolver(ObiSolver solver)
		{
		}

		public override void RemoveFromSolver(ObiSolver solver)
		{
		}
	}
}
