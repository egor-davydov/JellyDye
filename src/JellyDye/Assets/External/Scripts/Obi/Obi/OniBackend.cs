namespace Obi
{
	public class OniBackend : IObiBackend
	{
		private OniColliderWorld colliderGrid;

		public ISolverImpl CreateSolver(ObiSolver solver, int capacity)
		{
			return null;
		}

		public void DestroySolver(ISolverImpl solver)
		{
		}

		private void GetOrCreateColliderWorld()
		{
		}
	}
}
