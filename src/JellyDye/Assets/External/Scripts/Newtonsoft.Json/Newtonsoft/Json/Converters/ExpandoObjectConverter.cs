using System;

namespace Newtonsoft.Json.Converters
{
	public class ExpandoObjectConverter : JsonConverter
	{
		public override bool CanWrite => false;

		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
		}

		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		private object ReadValue(JsonReader reader)
		{
			return null;
		}

		private object ReadList(JsonReader reader)
		{
			return null;
		}

		private object ReadObject(JsonReader reader)
		{
			return null;
		}

		public override bool CanConvert(Type objectType)
		{
			return false;
		}
	}
}
