using System;
using System.Collections.Generic;
using UnityEngine;

namespace Obi
{
	[Serializable]
	public class ObiAerodynamicConstraintsBatch : ObiConstraintsBatch
	{
		protected IAerodynamicConstraintsBatchImpl m_BatchImpl;

		[HideInInspector]
		public ObiNativeFloatList aerodynamicCoeffs;

		public override Oni.ConstraintType constraintType => default(Oni.ConstraintType);

		public override IConstraintsBatchImpl implementation => null;

		public ObiAerodynamicConstraintsBatch(ObiAerodynamicConstraintsData constraints = null)
		{
		}

		public void AddConstraint(int index, float area, float drag, float lift)
		{
		}

		public override void GetParticlesInvolved(int index, List<int> particles)
		{
		}

		public override void Clear()
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
