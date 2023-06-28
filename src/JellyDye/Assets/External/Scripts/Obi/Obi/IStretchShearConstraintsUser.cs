namespace Obi
{
	public interface IStretchShearConstraintsUser
	{
		bool stretchShearConstraintsEnabled { get; set; }

		float stretchCompliance { get; set; }

		float shear1Compliance { get; set; }

		float shear2Compliance { get; set; }
	}
}
