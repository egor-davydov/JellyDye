using System;
using System.IO;

namespace Newtonsoft.Json.Serialization
{
	internal class TraceJsonReader : JsonReader, IJsonLineInfo
	{
		private readonly JsonReader _innerReader;

		private readonly JsonTextWriter _textWriter;

		private readonly StringWriter _sw;

		public override int Depth => 0;

		public override string Path => null;

		public override JsonToken TokenType => default(JsonToken);

		public override object Value => null;

		public override Type ValueType => null;

		private int Newtonsoft_002EJson_002EIJsonLineInfo_002ELineNumber => 0;

		private int Newtonsoft_002EJson_002EIJsonLineInfo_002ELinePosition => 0;

		public TraceJsonReader(JsonReader innerReader)
		{
		}

		public string GetDeserializedJsonMessage()
		{
			return null;
		}

		public override bool Read()
		{
			return false;
		}

		public override int? ReadAsInt32()
		{
			return null;
		}

		public override string ReadAsString()
		{
			return null;
		}

		public override byte[] ReadAsBytes()
		{
			return null;
		}

		public override decimal? ReadAsDecimal()
		{
			return null;
		}

		public override double? ReadAsDouble()
		{
			return null;
		}

		public override bool? ReadAsBoolean()
		{
			return null;
		}

		public override DateTime? ReadAsDateTime()
		{
			return null;
		}

		public override DateTimeOffset? ReadAsDateTimeOffset()
		{
			return null;
		}

		public void WriteCurrentToken()
		{
		}

		public override void Close()
		{
		}

		private bool Newtonsoft_002EJson_002EIJsonLineInfo_002EHasLineInfo()
		{
			return false;
		}
	}
}
