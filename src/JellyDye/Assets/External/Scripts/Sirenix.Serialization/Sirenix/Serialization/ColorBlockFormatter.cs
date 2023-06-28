using System.Reflection;
using UnityEngine;

namespace Sirenix.Serialization
{
	public class ColorBlockFormatter<T> : MinimalBaseFormatter<T>
	{
		private static readonly Serializer<float> FloatSerializer;

		private static readonly Serializer<Color> ColorSerializer;

		private static readonly PropertyInfo normalColor;

		private static readonly PropertyInfo highlightedColor;

		private static readonly PropertyInfo pressedColor;

		private static readonly PropertyInfo disabledColor;

		private static readonly PropertyInfo colorMultiplier;

		private static readonly PropertyInfo fadeDuration;

		protected override void Read(ref T value, IDataReader reader)
		{
		}

		protected override void Write(ref T value, IDataWriter writer)
		{
		}

		public ColorBlockFormatter()
		{
			((MinimalBaseFormatter<>)(object)this)._002Ector();
		}
	}
}
