using System;
using System.Runtime.Serialization;

namespace Newtonsoft.Json.Serialization
{
	internal class JsonFormatterConverter : IFormatterConverter
	{
		private readonly JsonSerializerInternalReader _reader;

		private readonly JsonISerializableContract _contract;

		private readonly JsonProperty _member;

		public JsonFormatterConverter(JsonSerializerInternalReader reader, JsonISerializableContract contract, JsonProperty member)
		{
		}

		private T GetTokenValue<T>(object value)
		{
			return default(T);
		}

		public object Convert(object value, Type type)
		{
			return null;
		}

		public bool ToBoolean(object value)
		{
			return false;
		}

		public int ToInt32(object value)
		{
			return 0;
		}

		public long ToInt64(object value)
		{
			return 0L;
		}

		public float ToSingle(object value)
		{
			return 0f;
		}

		public string ToString(object value)
		{
			return null;
		}
	}
}
