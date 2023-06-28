using System.Collections.Generic;
using Unity.Profiling;
using UnityEngine;

namespace Obi
{
	[ExecuteInEditMode]
	public abstract class ObiUpdater : MonoBehaviour
	{
		private static ProfilerMarker m_BeginStepPerfMarker;

		private static ProfilerMarker m_SubstepPerfMarker;

		private static ProfilerMarker m_EndStepPerfMarker;

		private static ProfilerMarker m_InterpolatePerfMarker;

		public List<ObiSolver> solvers;

		protected void BeginStep(float stepDeltaTime)
		{
		}

		protected void Substep(float substepDeltaTime)
		{
		}

		protected void EndStep(float substepDeltaTime)
		{
		}

		protected void Interpolate(float stepDeltaTime, float accumulatedTime)
		{
		}
	}
}
