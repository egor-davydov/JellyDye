using UnityEngine;

namespace Sirenix.Serialization
{
	public class Vector3Formatter : MinimalBaseFormatter<Vector3>
	{
		private static readonly Serializer<float> FloatSerializer;

		protected override void Read(ref Vector3 value, IDataReader reader)
		{
		}

		protected override void Write(ref Vector3 value, IDataWriter writer)
		{
		}

		public Vector3Formatter()
		{
			((MinimalBaseFormatter<>)(object)this)._002Ector();
		}
	}
}
