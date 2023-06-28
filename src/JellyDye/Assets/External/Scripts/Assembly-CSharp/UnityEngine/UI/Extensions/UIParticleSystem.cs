namespace UnityEngine.UI.Extensions
{
	[ExecuteInEditMode]
	public class UIParticleSystem : MaskableGraphic
	{
		public bool fixedTime;

		public bool use3dRotation;

		private Transform _transform;

		private ParticleSystem pSystem;

		private ParticleSystem.Particle[] particles;

		private UIVertex[] _quad;

		private Vector4 imageUV;

		private ParticleSystem.TextureSheetAnimationModule textureSheetAnimation;

		private int textureSheetAnimationFrames;

		private Vector2 textureSheetAnimationFrameSize;

		private ParticleSystemRenderer pRenderer;

		private bool isInitialised;

		private Material currentMaterial;

		private Texture currentTexture;

		private ParticleSystem.MainModule mainModule;

		public override Texture mainTexture => null;

		protected bool Initialize()
		{
			return false;
		}

		protected override void Awake()
		{
		}

		protected override void OnPopulateMesh(VertexHelper vh)
		{
		}

		private void Update()
		{
		}

		private void LateUpdate()
		{
		}

		protected override void OnDestroy()
		{
		}

		public void StartParticleEmission()
		{
		}

		public void StopParticleEmission()
		{
		}

		public void PauseParticleEmission()
		{
		}
	}
}
