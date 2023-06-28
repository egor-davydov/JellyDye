namespace Obi
{
	public interface IBendConstraintsUser
	{
		bool bendConstraintsEnabled { get; set; }

		float bendCompliance { get; set; }

		float maxBending { get; set; }
	}
}
