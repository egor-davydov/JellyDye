namespace Obi
{
	public class OniShapeMatchingConstraintsImpl : OniConstraintsImpl
	{
		public OniShapeMatchingConstraintsImpl(OniSolverImpl solver)
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
