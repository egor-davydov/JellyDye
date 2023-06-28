namespace Obi
{
	public struct CollisionMaterial
	{
		public float dynamicFriction;

		public float staticFriction;

		public float rollingFriction;

		public float stickiness;

		public float stickDistance;

		public Oni.MaterialCombineMode frictionCombine;

		public Oni.MaterialCombineMode stickinessCombine;

		public int rollingContacts;

		public void FromObiCollisionMaterial(ObiCollisionMaterial material)
		{
		}
	}
}
