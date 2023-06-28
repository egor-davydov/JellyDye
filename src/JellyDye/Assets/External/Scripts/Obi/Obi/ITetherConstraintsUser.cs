namespace Obi
{
	public interface ITetherConstraintsUser
	{
		bool tetherConstraintsEnabled { get; set; }

		float tetherCompliance { get; set; }

		float tetherScale { get; set; }
	}
}
