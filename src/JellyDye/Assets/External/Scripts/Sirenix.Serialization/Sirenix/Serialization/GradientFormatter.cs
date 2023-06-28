using System.Reflection;
using UnityEngine;

namespace Sirenix.Serialization
{
	public class GradientFormatter : MinimalBaseFormatter<Gradient>
	{
		private static readonly Serializer<GradientAlphaKey[]> AlphaKeysSerializer;

		private static readonly Serializer<GradientColorKey[]> ColorKeysSerializer;

		private static readonly PropertyInfo ModeProperty;

		private static readonly Serializer<object> EnumSerializer;

		protected override Gradient GetUninitializedObject()
		{
			return null;
		}

		protected override void Read(ref Gradient value, IDataReader reader)
		{
		}

		protected override void Write(ref Gradient value, IDataWriter writer)
		{
		}

		public GradientFormatter()
		{
			((MinimalBaseFormatter<>)(object)this)._002Ector();
		}
	}
}
