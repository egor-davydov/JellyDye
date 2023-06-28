using System;
using System.IO;

namespace Newtonsoft.Json.Serialization
{
	internal class TraceJsonWriter : JsonWriter
	{
		private readonly JsonWriter _innerWriter;

		private readonly JsonTextWriter _textWriter;

		private readonly StringWriter _sw;

		public TraceJsonWriter(JsonWriter innerWriter)
		{
		}

		public string GetSerializedJsonMessage()
		{
			return null;
		}

		public override void WriteValue(decimal value)
		{
		}

		public override void WriteValue(decimal? value)
		{
		}

		public override void WriteValue(bool value)
		{
		}

		public override void WriteValue(bool? value)
		{
		}

		public override void WriteValue(byte value)
		{
		}

		public override void WriteValue(byte? value)
		{
		}

		public override void WriteValue(char value)
		{
		}

		public override void WriteValue(char? value)
		{
		}

		public override void WriteValue(byte[] value)
		{
		}

		public override void WriteValue(DateTime value)
		{
		}

		public override void WriteValue(DateTime? value)
		{
		}

		public override void WriteValue(DateTimeOffset value)
		{
		}

		public override void WriteValue(DateTimeOffset? value)
		{
		}

		public override void WriteValue(double value)
		{
		}

		public override void WriteValue(double? value)
		{
		}

		public override void WriteUndefined()
		{
		}

		public override void WriteNull()
		{
		}

		public override void WriteValue(float value)
		{
		}

		public override void WriteValue(float? value)
		{
		}

		public override void WriteValue(Guid value)
		{
		}

		public override void WriteValue(Guid? value)
		{
		}

		public override void WriteValue(int value)
		{
		}

		public override void WriteValue(int? value)
		{
		}

		public override void WriteValue(long value)
		{
		}

		public override void WriteValue(long? value)
		{
		}

		public override void WriteValue(object value)
		{
		}

		public override void WriteValue(sbyte value)
		{
		}

		public override void WriteValue(sbyte? value)
		{
		}

		public override void WriteValue(short value)
		{
		}

		public override void WriteValue(short? value)
		{
		}

		public override void WriteValue(string value)
		{
		}

		public override void WriteValue(TimeSpan value)
		{
		}

		public override void WriteValue(TimeSpan? value)
		{
		}

		public override void WriteValue(uint value)
		{
		}

		public override void WriteValue(uint? value)
		{
		}

		public override void WriteValue(ulong value)
		{
		}

		public override void WriteValue(ulong? value)
		{
		}

		public override void WriteValue(Uri value)
		{
		}

		public override void WriteValue(ushort value)
		{
		}

		public override void WriteValue(ushort? value)
		{
		}

		public override void WriteComment(string text)
		{
		}

		public override void WriteStartArray()
		{
		}

		public override void WriteEndArray()
		{
		}

		public override void WriteStartConstructor(string name)
		{
		}

		public override void WriteEndConstructor()
		{
		}

		public override void WritePropertyName(string name)
		{
		}

		public override void WritePropertyName(string name, bool escape)
		{
		}

		public override void WriteStartObject()
		{
		}

		public override void WriteEndObject()
		{
		}

		public override void WriteRawValue(string json)
		{
		}

		public override void WriteRaw(string json)
		{
		}

		public override void Close()
		{
		}
	}
}
