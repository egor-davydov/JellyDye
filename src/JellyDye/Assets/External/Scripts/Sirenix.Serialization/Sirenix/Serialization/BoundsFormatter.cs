using UnityEngine;

namespace Sirenix.Serialization
{
	public class BoundsFormatter : MinimalBaseFormatter<Bounds>
	{
		private static readonly Serializer<Vector3> Vector3Serializer;

		protected override void Read(ref Bounds value, IDataReader reader)
		{
		}

		protected override void Write(ref Bounds value, IDataWriter writer)
		{
		}

		public BoundsFormatter()
		{
			((MinimalBaseFormatter<>)(object)this)._002Ector();
		}
	}
}
