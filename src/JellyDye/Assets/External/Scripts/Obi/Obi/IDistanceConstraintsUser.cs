namespace Obi
{
	public interface IDistanceConstraintsUser
	{
		bool distanceConstraintsEnabled { get; set; }

		float stretchingScale { get; set; }

		float stretchCompliance { get; set; }

		float maxCompression { get; set; }
	}
}
