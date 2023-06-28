namespace Obi
{
	public class OniSkinConstraintsImpl : OniConstraintsImpl
	{
		public OniSkinConstraintsImpl(OniSolverImpl solver)
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
