namespace Obi
{
	public class OniChainConstraintsBatchImpl : OniConstraintsBatchImpl, IChainConstraintsBatchImpl, IConstraintsBatchImpl
	{
		public OniChainConstraintsBatchImpl(OniChainConstraintsImpl constraints)
			: base(null, default(Oni.ConstraintType))
		{
		}

		public void SetChainConstraints(ObiNativeIntList particleIndices, ObiNativeVector2List restLengths, ObiNativeIntList firstIndex, ObiNativeIntList numIndices, int count)
		{
		}
	}
}
