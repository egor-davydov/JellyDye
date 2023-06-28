namespace Obi
{
	public struct StructuralConstraint
	{
		public IStructuralConstraintBatch batchIndex;

		public int constraintIndex;

		public float force;

		public float restLength
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public StructuralConstraint(IStructuralConstraintBatch batchIndex, int constraintIndex, float force)
		{
		}
	}
}
