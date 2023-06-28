using UnityEngine;

namespace Sirenix.Serialization
{
	public class GradientColorKeyFormatter : MinimalBaseFormatter<GradientColorKey>
	{
		private static readonly Serializer<Color> ColorSerializer;

		private static readonly Serializer<float> FloatSerializer;

		protected override void Read(ref GradientColorKey value, IDataReader reader)
		{
		}

		protected override void Write(ref GradientColorKey value, IDataWriter writer)
		{
		}

		public GradientColorKeyFormatter()
		{
			((MinimalBaseFormatter<>)(object)this)._002Ector();
		}
	}
}
