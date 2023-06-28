namespace Obi
{
	public class OniPinConstraintsBatchImpl : OniConstraintsBatchImpl, IPinConstraintsBatchImpl, IConstraintsBatchImpl
	{
		public OniPinConstraintsBatchImpl(OniPinConstraintsImpl constraints)
			: base(null, default(Oni.ConstraintType))
		{
		}

		public void SetPinConstraints(ObiNativeIntList particleIndices, ObiNativeIntList colliderIndices, ObiNativeVector4List offsets, ObiNativeQuaternionList restDarbouxVectors, ObiNativeFloatList stiffnesses, ObiNativeFloatList lambdas, int count)
		{
		}
	}
}
