namespace Newtonsoft.Json.Linq
{
	public class JRaw : JValue
	{
		public JRaw(JRaw other)
			: base(null, default(JTokenType))
		{
		}

		public JRaw(object rawJson)
			: base(null, default(JTokenType))
		{
		}

		public static JRaw Create(JsonReader reader)
		{
			return null;
		}

		internal override JToken CloneToken()
		{
			return null;
		}
	}
}
