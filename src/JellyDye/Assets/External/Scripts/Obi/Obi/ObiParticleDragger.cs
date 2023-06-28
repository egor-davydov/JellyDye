using UnityEngine;

namespace Obi
{
	public class ObiParticleDragger : MonoBehaviour
	{
		public float springStiffness;

		public float springDamping;

		public bool drawSpring;

		private LineRenderer lineRenderer;

		private ObiParticlePicker picker;

		private ObiParticlePicker.ParticlePickEventArgs pickArgs;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void FixedUpdate()
		{
		}

		private void Picker_OnParticleDragged(ObiParticlePicker.ParticlePickEventArgs e)
		{
		}

		private void Picker_OnParticleReleased(ObiParticlePicker.ParticlePickEventArgs e)
		{
		}
	}
}
