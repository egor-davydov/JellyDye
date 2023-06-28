namespace Obi
{
	public interface IOniConstraintsImpl : IConstraints
	{
		IConstraintsBatchImpl CreateConstraintsBatch();

		void RemoveBatch(IConstraintsBatchImpl batch);
	}
}
