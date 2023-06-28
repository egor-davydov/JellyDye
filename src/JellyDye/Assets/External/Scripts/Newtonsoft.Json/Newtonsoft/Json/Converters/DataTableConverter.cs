using System;
using System.Data;

namespace Newtonsoft.Json.Converters
{
	public class DataTableConverter : JsonConverter
	{
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
		}

		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		private static void CreateRow(JsonReader reader, DataTable dt, JsonSerializer serializer)
		{
		}

		private static Type GetColumnDataType(JsonReader reader)
		{
			return null;
		}

		public override bool CanConvert(Type valueType)
		{
			return false;
		}
	}
}
