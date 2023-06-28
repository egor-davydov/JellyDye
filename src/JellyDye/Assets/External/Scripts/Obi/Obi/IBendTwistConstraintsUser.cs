namespace Obi
{
	public interface IBendTwistConstraintsUser
	{
		bool bendTwistConstraintsEnabled { get; set; }

		float torsionCompliance { get; set; }

		float bend1Compliance { get; set; }

		float bend2Compliance { get; set; }
	}
}
