using System;

namespace Obi
{
	public class OniConstraintsBatchImpl : IConstraintsBatchImpl
	{
		protected IConstraints m_Constraints;

		protected Oni.ConstraintType m_ConstraintType;

		protected IntPtr m_OniBatch;

		protected bool m_Enabled;

		public IntPtr oniBatch => (IntPtr)0;

		public Oni.ConstraintType constraintType => default(Oni.ConstraintType);

		public IConstraints constraints => null;

		public bool enabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public OniConstraintsBatchImpl(IConstraints constraints, Oni.ConstraintType type)
		{
		}

		public void Destroy()
		{
		}

		public void SetConstraintCount(int constraintCount)
		{
		}

		public int GetConstraintCount()
		{
			return 0;
		}
	}
}
