using UnityEngine;

namespace Kino
{
	[ExecuteInEditMode]
	[ImageEffectAllowedInSceneView]
	public class Bloom : MonoBehaviour
	{
		[SerializeField]
		private float _threshold;

		[SerializeField]
		private float _softKnee;

		[SerializeField]
		private float _radius;

		[SerializeField]
		private float _intensity;

		[SerializeField]
		private bool _highQuality;

		[SerializeField]
		private bool _antiFlicker;

		[SerializeField]
		[HideInInspector]
		private Shader _shader;

		private Material _material;

		private const int kMaxIterations = 16;

		private RenderTexture[] _blurBuffer1;

		private RenderTexture[] _blurBuffer2;

		public float thresholdGamma
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float thresholdLinear
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float softKnee
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float radius
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float intensity
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool highQuality
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool antiFlicker
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		private float LinearToGamma(float x)
		{
			return 0f;
		}

		private float GammaToLinear(float x)
		{
			return 0f;
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}
	}
}
