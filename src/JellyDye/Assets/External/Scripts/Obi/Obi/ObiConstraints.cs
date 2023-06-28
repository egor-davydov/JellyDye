using System;
using System.Collections.Generic;
using UnityEngine;

namespace Obi
{
	[Serializable]
	public abstract class ObiConstraints<T> : IObiConstraints where T : class, IObiConstraintsBatch
	{
		[NonSerialized]
		protected ObiSolver m_Solver;

		[HideInInspector]
		public List<T> batches;

		public void Merge(ObiActor actor, IObiConstraints other)
		{
		}

		public IObiConstraintsBatch GetBatch(int i)
		{
			return null;
		}

		public int GetBatchCount()
		{
			return 0;
		}

		public int GetConstraintCount()
		{
			return 0;
		}

		public int GetActiveConstraintCount()
		{
			return 0;
		}

		public void DeactivateAllConstraints()
		{
		}

		public T GetFirstBatch()
		{
			return null;
		}

		public Oni.ConstraintType? GetConstraintType()
		{
			return null;
		}

		public void Clear()
		{
		}

		public virtual T CreateBatch(T source = null)
		{
			return null;
		}

		public void AddBatch(T batch)
		{
		}

		public bool RemoveBatch(T batch)
		{
			return false;
		}

		public bool AddToSolver(ObiSolver solver)
		{
			return false;
		}

		public bool RemoveFromSolver()
		{
			return false;
		}
	}
}
