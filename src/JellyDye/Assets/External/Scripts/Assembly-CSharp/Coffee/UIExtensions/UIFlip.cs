using UnityEngine;
using UnityEngine.UI;

namespace Coffee.UIExtensions
{
	[DisallowMultipleComponent]
	public class UIFlip : BaseMeshEffect
	{
		[SerializeField]
		private bool m_Horizontal;

		[SerializeField]
		private bool m_Veritical;

		public bool horizontal
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool vertical
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
