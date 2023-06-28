using System;
using UnityEngine;
using UnityEngine.UI;

namespace Coffee.UIExtensions
{
	public class UIDissolve : UIEffectBase
	{
		public const string shaderName = "UI/Hidden/UI-Effect-Dissolve";

		private static readonly ParameterTexture _ptex;

		[SerializeField]
		private float m_EffectFactor;

		[SerializeField]
		private float m_Width;

		[SerializeField]
		private float m_Softness;

		[SerializeField]
		private Color m_Color;

		[SerializeField]
		private ColorMode m_ColorMode;

		[SerializeField]
		private Texture m_NoiseTexture;

		[SerializeField]
		protected EffectArea m_EffectArea;

		[SerializeField]
		private bool m_KeepAspectRatio;

		[SerializeField]
		private EffectPlayer m_Player;

		[HideInInspector]
		[SerializeField]
		private bool m_ReverseAnimation;

		[Obsolete]
		[HideInInspector]
		[SerializeField]
		private float m_Duration;

		[Obsolete]
		[HideInInspector]
		[SerializeField]
		private AnimatorUpdateMode m_UpdateMode;

		private MaterialCache _materialCache;

		[Obsolete]
		public float location
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

		public float width
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float softness
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public Color color
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public Texture noiseTexture
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public EffectArea effectArea
		{
			get
			{
				return default(EffectArea);
			}
			set
			{
			}
		}

		public bool keepAspectRatio
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public ColorMode colorMode => default(ColorMode);

		[Obsolete]
		public bool play
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
		public bool loop
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float duration
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
		public float loopDelay
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public AnimatorUpdateMode updateMode
		{
			get
			{
				return default(AnimatorUpdateMode);
			}
			set
			{
			}
		}

		public override ParameterTexture ptex => null;

		private EffectPlayer _player => null;

		public override void ModifyMaterial()
		{
		}

		public override void ModifyMesh(VertexHelper vh)
		{
		}

		protected override void SetDirty()
		{
		}

		public void Play()
		{
		}

		public void Stop()
		{
		}

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}
	}
}
