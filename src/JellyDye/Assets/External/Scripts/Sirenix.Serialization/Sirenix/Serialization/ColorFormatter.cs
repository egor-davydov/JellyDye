using UnityEngine;

namespace Sirenix.Serialization
{
	public class ColorFormatter : MinimalBaseFormatter<Color>
	{
		private static readonly Serializer<float> FloatSerializer;

		protected override void Read(ref Color value, IDataReader reader)
		{
		}

		protected override void Write(ref Color value, IDataWriter writer)
		{
		}

		public ColorFormatter()
		{
			((MinimalBaseFormatter<>)(object)this)._002Ector();
		}
	}
}
