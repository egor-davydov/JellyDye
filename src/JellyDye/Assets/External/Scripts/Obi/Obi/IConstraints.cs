namespace Obi
{
	public interface IConstraints
	{
		Oni.ConstraintType constraintType { get; }

		ISolverImpl solver { get; }

		int GetConstraintCount();
	}
}
