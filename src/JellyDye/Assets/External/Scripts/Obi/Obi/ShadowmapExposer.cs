using UnityEngine;
using UnityEngine.Rendering;

namespace Obi
{
	public class ShadowmapExposer : MonoBehaviour
	{
		private Light unityLight;

		private CommandBuffer afterShadow;

		public ObiParticleRenderer[] particleRenderers;

		public void Awake()
		{
		}

		public void OnEnable()
		{
		}

		public void OnDisable()
		{
		}

		private void Cleanup()
		{
		}

		public void SetupFluidShadowsCommandBuffer()
		{
		}

		private void Update()
		{
		}
	}
}
