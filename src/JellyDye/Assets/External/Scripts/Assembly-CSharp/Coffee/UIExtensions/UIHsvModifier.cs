using UnityEngine;
using UnityEngine.UI;

namespace Coffee.UIExtensions
{
	public class UIHsvModifier : UIEffectBase
	{
		public const string shaderName = "UI/Hidden/UI-Effect-HSV";

		private static readonly ParameterTexture _ptex;

		[SerializeField]
		private Color m_TargetColor;

		[SerializeField]
		private float m_Range;

		[SerializeField]
		private float m_Hue;

		[SerializeField]
		private float m_Saturation;

		[SerializeField]
		private float m_Value;

		public Color targetColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public float range
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float saturation
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float value
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float hue
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public override ParameterTexture ptex => null;

		public override void ModifyMesh(VertexHelper vh)
		{
		}

		protected override void SetDirty()
		{
		}
	}
}
