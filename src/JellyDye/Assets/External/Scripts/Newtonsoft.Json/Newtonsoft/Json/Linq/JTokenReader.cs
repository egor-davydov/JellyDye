namespace Newtonsoft.Json.Linq
{
	public class JTokenReader : JsonReader, IJsonLineInfo
	{
		private readonly JToken _root;

		private string _initialPath;

		private JToken _parent;

		private JToken _current;

		public JToken CurrentToken => null;

		private int Newtonsoft_002EJson_002EIJsonLineInfo_002ELineNumber => 0;

		private int Newtonsoft_002EJson_002EIJsonLineInfo_002ELinePosition => 0;

		public override string Path => null;

		public JTokenReader(JToken token)
		{
		}

		public override bool Read()
		{
			return false;
		}

		private bool ReadOver(JToken t)
		{
			return false;
		}

		private bool ReadToEnd()
		{
			return false;
		}

		private JsonToken? GetEndToken(JContainer c)
		{
			return null;
		}

		private bool ReadInto(JContainer c)
		{
			return false;
		}

		private bool SetEnd(JContainer c)
		{
			return false;
		}

		private void SetToken(JToken token)
		{
		}

		private string SafeToString(object value)
		{
			return null;
		}

		private bool Newtonsoft_002EJson_002EIJsonLineInfo_002EHasLineInfo()
		{
			return false;
		}
	}
}
