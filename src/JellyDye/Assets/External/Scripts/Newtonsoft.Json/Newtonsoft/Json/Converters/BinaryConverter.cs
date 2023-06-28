using System;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Converters
{
	public class BinaryConverter : JsonConverter
	{
		private const string BinaryTypeName = "System.Data.Linq.Binary";

		private const string BinaryToArrayName = "ToArray";

		private static ReflectionObject _reflectionObject;

		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
		}

		private byte[] GetByteArray(object value)
		{
			return null;
		}

		private static void EnsureReflectionObject(Type t)
		{
		}

		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		private byte[] ReadByteArray(JsonReader reader)
		{
			return null;
		}

		public override bool CanConvert(Type objectType)
		{
			return false;
		}
	}
}
