using UnityEngine;

namespace GJG.Ingame
{
	public class SimulationManager : MonoBehaviour
	{
		[SerializeField]
		private GameObject LevelEndCameraTransform;

		private FluidSimulationController _fluidSimulationController;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnRemovalCompleted()
		{
		}

		private void OnInjectionCompleted()
		{
		}
	}
}
