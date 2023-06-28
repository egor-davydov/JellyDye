namespace Obi
{
	public interface IAerodynamicConstraintsUser
	{
		bool aerodynamicsEnabled { get; set; }

		float drag { get; set; }

		float lift { get; set; }
	}
}
