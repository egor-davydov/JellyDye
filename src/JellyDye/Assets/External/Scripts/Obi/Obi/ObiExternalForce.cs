using UnityEngine;

namespace Obi
{
	public abstract class ObiExternalForce : MonoBehaviour
	{
		public float intensity;

		public float turbulence;

		public float turbulenceFrequency;

		public float turbulenceSeed;

		public ObiSolver[] affectedSolvers;

		public void OnEnable()
		{
		}

		public void OnDisable()
		{
		}

		private void Solver_OnStepBegin(ObiSolver solver, float stepTime)
		{
		}

		protected float GetTurbulence(float turbulenceIntensity)
		{
			return 0f;
		}

		public abstract void ApplyForcesToActor(ObiActor actor);
	}
}
