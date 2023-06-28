using System;
using System.Collections.Generic;
using UnityEngine;

namespace Obi
{
	[Serializable]
	public class ObiTetherConstraintsBatch : ObiConstraintsBatch
	{
		protected ITetherConstraintsBatchImpl m_BatchImpl;

		[HideInInspector]
		public ObiNativeVector2List maxLengthsScales;

		[HideInInspector]
		public ObiNativeFloatList stiffnesses;

		public override Oni.ConstraintType constraintType => default(Oni.ConstraintType);

		public override IConstraintsBatchImpl implementation => null;

		public ObiTetherConstraintsBatch(ObiTetherConstraintsData constraints = null)
		{
		}

		public void AddConstraint(Vector2Int indices, float maxLength, float scale)
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

		public void SetParameters(float compliance, float scale)
		{
		}
	}
}
