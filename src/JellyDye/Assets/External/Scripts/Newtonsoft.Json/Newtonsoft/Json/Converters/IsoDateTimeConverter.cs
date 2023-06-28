using System;
using System.Globalization;

namespace Newtonsoft.Json.Converters
{
	public class IsoDateTimeConverter : DateTimeConverterBase
	{
		private const string DefaultDateTimeFormat = "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK";

		private DateTimeStyles _dateTimeStyles;

		private string _dateTimeFormat;

		private CultureInfo _culture;

		public DateTimeStyles DateTimeStyles
		{
			get
			{
				return default(DateTimeStyles);
			}
			set
			{
			}
		}

		public string DateTimeFormat
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public CultureInfo Culture
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
		}

		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			return null;
		}
	}
}
