using UnityEngine;
using UnityEngine.UI;

namespace Coffee.UIExtensions
{
	[DisallowMultipleComponent]
	public class UIGradient : BaseMeshEffect
	{
		public enum Direction
		{
			Horizontal = 0,
			Vertical = 1,
			Angle = 2,
			Diagonal = 3
		}

		public enum GradientStyle
		{
			Rect = 0,
			Fit = 1,
			Split = 2
		}

		private struct Matrix2x3
		{
			public float m00;

			public float m01;

			public float m02;

			public float m10;

			public float m11;

			public float m12;

			public Matrix2x3(Rect rect, float cos, float sin)
			{
			}

			public static Vector2 operator *(Matrix2x3 m, Vector2 v)
			{
				return default(Vector2);
			}
		}

		[SerializeField]
		private Direction m_Direction;

		[SerializeField]
		private Color m_Color1;

		[SerializeField]
		private Color m_Color2;

		[SerializeField]
		private Color m_Color3;

		[SerializeField]
		private Color m_Color4;

		[SerializeField]
		private float m_Rotation;

		[SerializeField]
		private float m_Offset1;

		[SerializeField]
		private float m_Offset2;

		[SerializeField]
		private GradientStyle m_GradientStyle;

		[SerializeField]
		private ColorSpace m_ColorSpace;

		[SerializeField]
		private bool m_IgnoreAspectRatio;

		private static readonly Vector2[] s_SplitedCharacterPosition;

		public Graphic targetGraphic => null;

		public Direction direction
		{
			get
			{
				return default(Direction);
			}
			set
			{
			}
		}

		public Color color1
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public Color color2
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public Color color3
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public Color color4
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public float rotation
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float offset
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public Vector2 offset2
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		public GradientStyle gradientStyle
		{
			get
			{
				return default(GradientStyle);
			}
			set
			{
			}
		}

		public ColorSpace colorSpace
		{
			get
			{
				return default(ColorSpace);
			}
			set
			{
			}
		}

		public bool ignoreAspectRatio
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public override void ModifyMesh(VertexHelper vh)
		{
		}
	}
}
