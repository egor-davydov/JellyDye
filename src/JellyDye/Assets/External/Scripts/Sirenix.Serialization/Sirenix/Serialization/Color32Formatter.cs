using UnityEngine;

namespace Sirenix.Serialization
{
	public class Color32Formatter : MinimalBaseFormatter<Color32>
	{
		private static readonly Serializer<byte> ByteSerializer;

		protected override void Read(ref Color32 value, IDataReader reader)
		{
		}

		protected override void Write(ref Color32 value, IDataWriter writer)
		{
		}

		public Color32Formatter()
		{
			((MinimalBaseFormatter<>)(object)this)._002Ector();
		}
	}
}
