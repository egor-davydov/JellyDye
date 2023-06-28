using UnityEngine;

namespace Obi
{
	[ExecuteInEditMode]
	public class ObiCollider2D : ObiColliderBase
	{
		[SerializeField]
		private Collider2D sourceCollider;

		public Collider2D SourceCollider
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected override void CreateTracker()
		{
		}

		protected override Component GetUnityCollider(ref bool enabled)
		{
			return null;
		}

		protected override void FindSourceCollider()
		{
		}
	}
}
