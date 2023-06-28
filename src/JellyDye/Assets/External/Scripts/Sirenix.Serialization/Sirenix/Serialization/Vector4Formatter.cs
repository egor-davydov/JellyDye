using UnityEngine;

namespace Sirenix.Serialization
{
	public class Vector4Formatter : MinimalBaseFormatter<Vector4>
	{
		private static readonly Serializer<float> FloatSerializer;

		protected override void Read(ref Vector4 value, IDataReader reader)
		{
		}

		protected override void Write(ref Vector4 value, IDataWriter writer)
		{
		}

		public Vector4Formatter()
		{
			((MinimalBaseFormatter<>)(object)this)._002Ector();
		}
	}
}
