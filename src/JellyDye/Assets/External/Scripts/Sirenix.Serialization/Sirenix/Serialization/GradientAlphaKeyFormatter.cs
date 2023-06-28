using UnityEngine;

namespace Sirenix.Serialization
{
	public class GradientAlphaKeyFormatter : MinimalBaseFormatter<GradientAlphaKey>
	{
		private static readonly Serializer<float> FloatSerializer;

		protected override void Read(ref GradientAlphaKey value, IDataReader reader)
		{
		}

		protected override void Write(ref GradientAlphaKey value, IDataWriter writer)
		{
		}

		public GradientAlphaKeyFormatter()
		{
			((MinimalBaseFormatter<>)(object)this)._002Ector();
		}
	}
}
