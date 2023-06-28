using UnityEngine;

namespace Sirenix.Serialization
{
	public class KeyframeFormatter : MinimalBaseFormatter<Keyframe>
	{
		private static readonly Serializer<float> FloatSerializer;

		private static readonly Serializer<int> IntSerializer;

		private static readonly bool Is_In_2018_1_Or_Above;

		private static IFormatter<Keyframe> Formatter;

		static KeyframeFormatter()
		{
		}

		protected override void Read(ref Keyframe value, IDataReader reader)
		{
		}

		protected override void Write(ref Keyframe value, IDataWriter writer)
		{
		}

		public KeyframeFormatter()
		{
			((MinimalBaseFormatter<>)(object)this)._002Ector();
		}
	}
}
