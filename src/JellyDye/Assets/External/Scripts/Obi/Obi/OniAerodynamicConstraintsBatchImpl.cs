namespace Obi
{
	public class OniAerodynamicConstraintsBatchImpl : OniConstraintsBatchImpl, IAerodynamicConstraintsBatchImpl, IConstraintsBatchImpl
	{
		public OniAerodynamicConstraintsBatchImpl(OniAerodynamicConstraintsImpl constraints)
			: base(null, default(Oni.ConstraintType))
		{
		}

		public void SetAerodynamicConstraints(ObiNativeIntList particleIndices, ObiNativeFloatList aerodynamicCoeffs, int count)
		{
		}
	}
}
