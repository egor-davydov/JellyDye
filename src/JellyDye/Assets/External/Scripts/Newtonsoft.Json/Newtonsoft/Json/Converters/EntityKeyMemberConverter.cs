using System;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Converters
{
	public class EntityKeyMemberConverter : JsonConverter
	{
		private const string EntityKeyMemberFullTypeName = "System.Data.EntityKeyMember";

		private const string KeyPropertyName = "Key";

		private const string TypePropertyName = "Type";

		private const string ValuePropertyName = "Value";

		private static ReflectionObject _reflectionObject;

		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
		}

		private static void ReadAndAssertProperty(JsonReader reader, string propertyName)
		{
		}

		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		private static void EnsureReflectionObject(Type objectType)
		{
		}

		public override bool CanConvert(Type objectType)
		{
			return false;
		}
	}
}
