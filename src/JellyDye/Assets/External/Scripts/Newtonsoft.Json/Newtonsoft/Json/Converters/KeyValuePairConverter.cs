using System;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Converters
{
	public class KeyValuePairConverter : JsonConverter
	{
		private const string KeyName = "Key";

		private const string ValueName = "Value";

		private static readonly ThreadSafeStore<Type, ReflectionObject> ReflectionObjectPerType;

		private static ReflectionObject InitializeReflectionObject(Type t)
		{
			return null;
		}

		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
		}

		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		public override bool CanConvert(Type objectType)
		{
			return false;
		}
	}
}
