using System;

namespace Newtonsoft.Json
{
	public abstract class JsonConverter
	{
		public virtual bool CanRead => false;

		public virtual bool CanWrite => false;

		public abstract void WriteJson(JsonWriter writer, object value, JsonSerializer serializer);

		public abstract object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer);

		public abstract bool CanConvert(Type objectType);
	}
}
