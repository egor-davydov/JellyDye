namespace Obi
{
	public class OniBendTwistConstraintsImpl : OniConstraintsImpl
	{
		public OniBendTwistConstraintsImpl(OniSolverImpl solver)
			: base(null, default(Oni.ConstraintType))
		{
		}

		public override IConstraintsBatchImpl CreateConstraintsBatch()
		{
			return null;
		}

		public override void RemoveBatch(IConstraintsBatchImpl batch)
		{
		}
	}
}
