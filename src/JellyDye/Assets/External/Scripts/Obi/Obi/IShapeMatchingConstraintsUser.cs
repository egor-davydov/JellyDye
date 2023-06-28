namespace Obi
{
	public interface IShapeMatchingConstraintsUser
	{
		bool shapeMatchingConstraintsEnabled { get; set; }

		float deformationResistance { get; set; }

		float maxDeformation { get; set; }

		float plasticYield { get; set; }

		float plasticCreep { get; set; }

		float plasticRecovery { get; set; }
	}
}
