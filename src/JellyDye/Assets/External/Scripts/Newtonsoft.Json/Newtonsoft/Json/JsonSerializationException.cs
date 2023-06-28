using System;
using System.Runtime.Serialization;

namespace Newtonsoft.Json
{
	[Serializable]
	public class JsonSerializationException : JsonException
	{
		public JsonSerializationException()
		{
		}

		public JsonSerializationException(string message)
		{
		}

		public JsonSerializationException(string message, Exception innerException)
		{
		}

		public JsonSerializationException(SerializationInfo info, StreamingContext context)
		{
		}

		public JsonSerializationException(string message, string path, int lineNumber, int linePosition, Exception innerException)
		{
		}

		internal static JsonSerializationException Create(JsonReader reader, string message)
		{
			return null;
		}

		internal static JsonSerializationException Create(JsonReader reader, string message, Exception ex)
		{
			return null;
		}

		internal static JsonSerializationException Create(IJsonLineInfo lineInfo, string path, string message, Exception ex)
		{
			return null;
		}
	}
}
