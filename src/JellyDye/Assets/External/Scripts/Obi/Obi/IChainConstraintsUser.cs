namespace Obi
{
	public interface IChainConstraintsUser
	{
		bool chainConstraintsEnabled { get; set; }

		float tightness { get; set; }
	}
}
