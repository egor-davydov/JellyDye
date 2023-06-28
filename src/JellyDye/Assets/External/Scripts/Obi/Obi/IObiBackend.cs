namespace Obi
{
	public interface IObiBackend
	{
		ISolverImpl CreateSolver(ObiSolver solver, int capacity);

		void DestroySolver(ISolverImpl solver);
	}
}
