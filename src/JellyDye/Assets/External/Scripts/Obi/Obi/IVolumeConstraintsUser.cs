namespace Obi
{
	public interface IVolumeConstraintsUser
	{
		bool volumeConstraintsEnabled { get; set; }

		float compressionCompliance { get; set; }

		float pressure { get; set; }
	}
}
