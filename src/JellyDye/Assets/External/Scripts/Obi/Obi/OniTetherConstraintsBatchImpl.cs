namespace Obi
{
	public class OniTetherConstraintsBatchImpl : OniConstraintsBatchImpl, ITetherConstraintsBatchImpl, IConstraintsBatchImpl
	{
		public OniTetherConstraintsBatchImpl(OniTetherConstraintsImpl constraints)
			: base(null, default(Oni.ConstraintType))
		{
		}

		public void SetTetherConstraints(ObiNativeIntList particleIndices, ObiNativeVector2List maxLengthScale, ObiNativeFloatList stiffnesses, ObiNativeFloatList lambdas, int count)
		{
		}
	}
}
