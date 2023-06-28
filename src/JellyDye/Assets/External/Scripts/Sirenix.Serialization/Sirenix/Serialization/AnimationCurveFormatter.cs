using UnityEngine;

namespace Sirenix.Serialization
{
	public class AnimationCurveFormatter : MinimalBaseFormatter<AnimationCurve>
	{
		private static readonly Serializer<Keyframe[]> KeyframeSerializer;

		private static readonly Serializer<WrapMode> WrapModeSerializer;

		protected override AnimationCurve GetUninitializedObject()
		{
			return null;
		}

		protected override void Read(ref AnimationCurve value, IDataReader reader)
		{
		}

		protected override void Write(ref AnimationCurve value, IDataWriter writer)
		{
		}

		public AnimationCurveFormatter()
		{
			((MinimalBaseFormatter<>)(object)this)._002Ector();
		}
	}
}
