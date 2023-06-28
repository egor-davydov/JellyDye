using UnityEngine;
using UnityEngine.UI;

namespace Coffee.UIExtensions
{
	public class UITransitionEffect : UIEffectBase
	{
		public enum EffectMode
		{
			Fade = 1,
			Cutoff = 2,
			Dissolve = 3
		}

		public const string shaderName = "UI/Hidden/UI-Effect-Transition";

		private static readonly ParameterTexture _ptex;

		[SerializeField]
		private EffectMode m_EffectMode;

		[SerializeField]
		private float m_EffectFactor;

		[SerializeField]
		private Texture m_TransitionTexture;

		[SerializeField]
		private EffectArea m_EffectArea;

		[SerializeField]
		private bool m_KeepAspectRatio;

		[SerializeField]
		private float m_DissolveWidth;

		[SerializeField]
		private float m_DissolveSoftness;

		[SerializeField]
		private Color m_DissolveColor;

		[SerializeField]
		private bool m_PassRayOnHidden;

		[SerializeField]
		private EffectPlayer m_Player;

		private MaterialCache _materialCache;

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

		public Texture transitionTexture
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public EffectMode effectMode => default(EffectMode);

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

		public override ParameterTexture ptex => null;

		public float dissolveWidth
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float dissolveSoftness
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public Color dissolveColor
		{
			get
			{
				return default(Color);
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

		public bool passRayOnHidden
		{
			get
			{
				return false;
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

		private EffectPlayer _player => null;

		public void Show()
		{
		}

		public void Hide()
		{
		}

		public override void ModifyMaterial()
		{
		}

		public override void ModifyMesh(VertexHelper vh)
		{
		}

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		protected override void SetDirty()
		{
		}
	}
}
