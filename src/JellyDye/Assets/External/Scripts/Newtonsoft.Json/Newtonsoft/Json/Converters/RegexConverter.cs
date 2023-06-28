using System;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using Newtonsoft.Json.Bson;

namespace Newtonsoft.Json.Converters
{
	public class RegexConverter : JsonConverter
	{
		private const string PatternName = "Pattern";

		private const string OptionsName = "Options";

		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
		}

		private bool HasFlag(RegexOptions options, RegexOptions flag)
		{
			return false;
		}

		private void WriteBson(BsonWriter writer, Regex regex)
		{
		}

		private void WriteJson(JsonWriter writer, Regex regex, JsonSerializer serializer)
		{
		}

		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		private object ReadRegexString(JsonReader reader)
		{
			return null;
		}

		private Regex ReadRegexObject(JsonReader reader, JsonSerializer serializer)
		{
			return null;
		}

		public override bool CanConvert(Type objectType)
		{
			return false;
		}

		[MethodImpl(8)]
		private bool IsRegex(Type objectType)
		{
			return false;
		}
	}
}
