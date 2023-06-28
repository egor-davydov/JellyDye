namespace Obi
{
	public class OniDistanceConstraintsBatchImpl : OniConstraintsBatchImpl, IDistanceConstraintsBatchImpl, IConstraintsBatchImpl
	{
		public OniDistanceConstraintsBatchImpl(OniDistanceConstraintsImpl constraints)
			: base(null, default(Oni.ConstraintType))
		{
		}

		public void SetDistanceConstraints(ObiNativeIntList particleIndices, ObiNativeFloatList restLengths, ObiNativeVector2List stiffnesses, ObiNativeFloatList lambdas, int count)
		{
		}
	}
}
