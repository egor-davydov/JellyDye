using System;
using System.IO;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json
{
	public class JsonTextWriter : JsonWriter
	{
		private readonly bool _safeAsync;

		private readonly TextWriter _writer;

		private Base64Encoder _base64Encoder;

		private char _indentChar;

		private int _indentation;

		private char _quoteChar;

		private bool _quoteName;

		private bool[] _charEscapeFlags;

		private char[] _writeBuffer;

		private IArrayPool<char> _arrayPool;

		private char[] _indentChars;

		private Base64Encoder Base64Encoder => null;

		public char QuoteChar => '\0';

		public JsonTextWriter(TextWriter textWriter)
		{
		}

		public override void Close()
		{
		}

		private void CloseBufferAndWriter()
		{
		}

		public override void WriteStartObject()
		{
		}

		public override void WriteStartArray()
		{
		}

		public override void WriteStartConstructor(string name)
		{
		}

		protected override void WriteEnd(JsonToken token)
		{
		}

		public override void WritePropertyName(string name)
		{
		}

		public override void WritePropertyName(string name, bool escape)
		{
		}

		internal override void OnStringEscapeHandlingChanged()
		{
		}

		private void UpdateCharEscapeFlags()
		{
		}

		protected override void WriteIndent()
		{
		}

		private int SetIndentChars()
		{
			return 0;
		}

		protected override void WriteValueDelimiter()
		{
		}

		protected override void WriteIndentSpace()
		{
		}

		private void WriteValueInternal(string value, JsonToken token)
		{
		}

		public override void WriteValue(object value)
		{
		}

		public override void WriteNull()
		{
		}

		public override void WriteUndefined()
		{
		}

		public override void WriteRaw(string json)
		{
		}

		public override void WriteValue(string value)
		{
		}

		private void WriteEscapedString(string value, bool quote)
		{
		}

		public override void WriteValue(int value)
		{
		}

		public override void WriteValue(uint value)
		{
		}

		public override void WriteValue(long value)
		{
		}

		public override void WriteValue(ulong value)
		{
		}

		public override void WriteValue(float value)
		{
		}

		public override void WriteValue(float? value)
		{
		}

		public override void WriteValue(double value)
		{
		}

		public override void WriteValue(double? value)
		{
		}

		public override void WriteValue(bool value)
		{
		}

		public override void WriteValue(short value)
		{
		}

		public override void WriteValue(ushort value)
		{
		}

		public override void WriteValue(char value)
		{
		}

		public override void WriteValue(byte value)
		{
		}

		public override void WriteValue(sbyte value)
		{
		}

		public override void WriteValue(decimal value)
		{
		}

		public override void WriteValue(DateTime value)
		{
		}

		private int WriteValueToBuffer(DateTime value)
		{
			return 0;
		}

		public override void WriteValue(byte[] value)
		{
		}

		public override void WriteValue(DateTimeOffset value)
		{
		}

		private int WriteValueToBuffer(DateTimeOffset value)
		{
			return 0;
		}

		public override void WriteValue(Guid value)
		{
		}

		public override void WriteValue(TimeSpan value)
		{
		}

		public override void WriteValue(Uri value)
		{
		}

		public override void WriteComment(string text)
		{
		}

		private void EnsureWriteBuffer()
		{
		}

		private void WriteIntegerValue(long value)
		{
		}

		private void WriteIntegerValue(ulong value, bool negative)
		{
		}

		private int WriteNumberToBuffer(ulong value, bool negative)
		{
			return 0;
		}

		private void WriteIntegerValue(int value)
		{
		}

		private void WriteIntegerValue(uint value, bool negative)
		{
		}

		private int WriteNumberToBuffer(uint value, bool negative)
		{
			return 0;
		}
	}
}
