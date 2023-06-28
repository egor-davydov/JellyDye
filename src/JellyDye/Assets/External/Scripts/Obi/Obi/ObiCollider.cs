using UnityEngine;

namespace Obi
{
	[ExecuteInEditMode]
	public class ObiCollider : ObiColliderBase
	{
		[SerializeField]
		private Collider m_SourceCollider;

		[SerializeField]
		private ObiDistanceField m_DistanceField;

		public Collider sourceCollider
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public ObiDistanceField distanceField
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
