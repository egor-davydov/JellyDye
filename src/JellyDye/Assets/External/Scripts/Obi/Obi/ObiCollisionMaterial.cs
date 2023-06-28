using UnityEngine;

namespace Obi
{
	[CreateAssetMenu]
	public class ObiCollisionMaterial : ScriptableObject
	{
		protected ObiCollisionMaterialHandle materialHandle;

		public float dynamicFriction;

		public float staticFriction;

		public float stickiness;

		public float stickDistance;

		public Oni.MaterialCombineMode frictionCombine;

		public Oni.MaterialCombineMode stickinessCombine;

		[Space]
		public bool rollingContacts;

		[Indent]
		public float rollingFriction;

		public ObiCollisionMaterialHandle handle => null;

		public void OnEnable()
		{
		}

		public void OnDisable()
		{
		}

		public void OnValidate()
		{
		}

		public void UpdateMaterial()
		{
		}

		protected void CreateMaterialIfNeeded()
		{
		}
	}
}
