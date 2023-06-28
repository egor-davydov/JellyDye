using UnityEngine;

namespace Sirenix.Serialization
{
	public class Vector2Formatter : MinimalBaseFormatter<Vector2>
	{
		private static readonly Serializer<float> FloatSerializer;

		protected override void Read(ref Vector2 value, IDataReader reader)
		{
		}

		protected override void Write(ref Vector2 value, IDataWriter writer)
		{
		}

		public Vector2Formatter()
		{
			((MinimalBaseFormatter<>)(object)this)._002Ector();
		}
	}
}
