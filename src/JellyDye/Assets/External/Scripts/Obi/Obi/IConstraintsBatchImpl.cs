namespace Obi
{
	public interface IConstraintsBatchImpl
	{
		Oni.ConstraintType constraintType { get; }

		IConstraints constraints { get; }

		bool enabled { get; set; }

		void Destroy();

		void SetConstraintCount(int constraintCount);

		int GetConstraintCount();
	}
}
