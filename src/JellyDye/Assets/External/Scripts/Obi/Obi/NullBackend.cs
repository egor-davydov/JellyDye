namespace Obi
{
	public class NullBackend : IObiBackend
	{
		public ISolverImpl CreateSolver(ObiSolver solver, int capacity)
		{
			return null;
		}

		public void DestroySolver(ISolverImpl solver)
		{
		}
	}
}
