using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

namespace Coffee.UIExtensions
{
	public class UIEffectCapturedImage : RawImage
	{
		public enum DesamplingRate
		{
			None = 0,
			x1 = 1,
			x2 = 2,
			x4 = 4,
			x8 = 8
		}

		public const string shaderName = "UI/Hidden/UI-EffectCapture";

		[SerializeField]
		private float m_EffectFactor;

		[SerializeField]
		private float m_ColorFactor;

		[SerializeField]
		private float m_BlurFactor;

		[SerializeField]
		private EffectMode m_EffectMode;

		[SerializeField]
		private ColorMode m_ColorMode;

		[SerializeField]
		private BlurMode m_BlurMode;

		[SerializeField]
		private Color m_EffectColor;

		[SerializeField]
		private DesamplingRate m_DesamplingRate;

		[SerializeField]
		private DesamplingRate m_ReductionRate;

		[SerializeField]
		private FilterMode m_FilterMode;

		[SerializeField]
		private Material m_EffectMaterial;

		[SerializeField]
		private int m_BlurIterations;

		[SerializeField]
		private bool m_FitToScreen;

		[SerializeField]
		private bool m_CaptureOnEnable;

		[SerializeField]
		private bool m_ImmediateCapturing;

		private RenderTexture _rt;

		private RenderTargetIdentifier _rtId;

		private static int s_CopyId;

		private static int s_EffectId1;

		private static int s_EffectId2;

		private static int s_EffectFactorId;

		private static int s_ColorFactorId;

		private static CommandBuffer s_CommandBuffer;

		[Obsolete]
		public float toneLevel
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float effectFactor
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float colorFactor
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		[Obsolete]
		public float blur
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float blurFactor
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		[Obsolete]
		public EffectMode toneMode => default(EffectMode);

		public EffectMode effectMode => default(EffectMode);

		public ColorMode colorMode => default(ColorMode);

		public BlurMode blurMode => default(BlurMode);

		public Color effectColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public virtual Material effectMaterial => null;

		public DesamplingRate desamplingRate
		{
			get
			{
				return default(DesamplingRate);
			}
			set
			{
			}
		}

		public DesamplingRate reductionRate
		{
			get
			{
				return default(DesamplingRate);
			}
			set
			{
			}
		}

		public FilterMode filterMode
		{
			get
			{
				return default(FilterMode);
			}
			set
			{
			}
		}

		public RenderTexture capturedTexture => null;

		[Obsolete]
		public int iterations
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int blurIterations
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[Obsolete]
		public bool keepCanvasSize
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool fitToScreen
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[Obsolete]
		public RenderTexture targetTexture
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool captureOnEnable
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool immediateCapturing
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		protected override void OnDestroy()
		{
		}

		protected override void OnPopulateMesh(VertexHelper vh)
		{
		}

		public void GetDesamplingSize(DesamplingRate rate, out int w, out int h)
		{
			w = default(int);
			h = default(int);
		}

		public void Capture()
		{
		}

		private void SetupCommandBuffer()
		{
		}

		public void Release()
		{
		}

		private void _Release(bool releaseRT)
		{
		}

		private void _SetDirty()
		{
		}

		private void _Release(ref RenderTexture obj)
		{
		}

		private IEnumerator _CoUpdateTextureOnNextFrame()
		{
			return null;
		}

		private void UpdateTexture()
		{
		}
	}
}
