using System;

namespace Newtonsoft.Json.Converters
{
	public abstract class CustomCreationConverter<T> : JsonConverter
	{
		public override bool CanWrite => false;

		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
		}

		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		public abstract T Create(Type objectType);

		public override bool CanConvert(Type objectType)
		{
			return false;
		}
	}
}
