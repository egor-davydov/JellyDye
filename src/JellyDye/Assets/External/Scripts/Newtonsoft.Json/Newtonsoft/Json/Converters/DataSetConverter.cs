using System;

namespace Newtonsoft.Json.Converters
{
	public class DataSetConverter : JsonConverter
	{
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
		}

		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		public override bool CanConvert(Type valueType)
		{
			return false;
		}
	}
}
