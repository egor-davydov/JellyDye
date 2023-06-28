using System.Collections.Generic;

namespace Newtonsoft.Json.Linq
{
	public class JConstructor : JContainer
	{
		private string _name;

		private readonly List<JToken> _values;

		protected override IList<JToken> ChildrenTokens => null;

		public string Name => null;

		public override JTokenType Type => default(JTokenType);

		internal override int IndexOfItem(JToken item)
		{
			return 0;
		}

		public JConstructor(JConstructor other)
		{
		}

		public JConstructor(string name)
		{
		}

		internal override JToken CloneToken()
		{
			return null;
		}

		public override void WriteTo(JsonWriter writer, params JsonConverter[] converters)
		{
		}

		public static JConstructor Load(JsonReader reader, JsonLoadSettings settings)
		{
			return null;
		}
	}
}
