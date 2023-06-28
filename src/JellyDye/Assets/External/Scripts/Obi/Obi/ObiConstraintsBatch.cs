using System.Collections.Generic;
using UnityEngine;

namespace Obi
{
	public abstract class ObiConstraintsBatch : IObiConstraintsBatch
	{
		[HideInInspector]
		[SerializeField]
		protected List<int> m_IDs;

		[HideInInspector]
		[SerializeField]
		protected List<int> m_IDToIndex;

		[HideInInspector]
		[SerializeField]
		protected int m_ConstraintCount;

		[HideInInspector]
		[SerializeField]
		protected int m_ActiveConstraintCount;

		[HideInInspector]
		[SerializeField]
		protected int m_InitialActiveConstraintCount;

		[HideInInspector]
		public ObiNativeIntList particleIndices;

		[HideInInspector]
		public ObiNativeFloatList lambdas;

		public int constraintCount => 0;

		public int activeConstraintCount
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public virtual int initialActiveConstraintCount
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public abstract Oni.ConstraintType constraintType { get; }

		public abstract IConstraintsBatchImpl implementation { get; }

		public virtual void Merge(ObiActor actor, IObiConstraintsBatch other)
		{
		}

		protected abstract void SwapConstraints(int sourceIndex, int destIndex);

		public abstract void GetParticlesInvolved(int index, List<int> particles);

		public abstract void AddToSolver(ObiSolver solver);

		public abstract void RemoveFromSolver(ObiSolver solver);

		protected virtual void CopyConstraint(ObiConstraintsBatch batch, int constraintIndex)
		{
		}

		private void InnerSwapConstraints(int sourceIndex, int destIndex)
		{
		}

		protected void RegisterConstraint()
		{
		}

		public virtual void Clear()
		{
		}

		public int GetConstraintIndex(int constraintId)
		{
			return 0;
		}

		public bool IsConstraintActive(int index)
		{
			return false;
		}

		public bool ActivateConstraint(int constraintIndex)
		{
			return false;
		}

		public bool DeactivateConstraint(int constraintIndex)
		{
			return false;
		}

		public void DeactivateAllConstraints()
		{
		}

		public void RemoveConstraint(int constraintIndex)
		{
		}

		public void ParticlesSwapped(int index, int newIndex)
		{
		}
	}
}
