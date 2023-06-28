using System.Collections;
using System.Collections.Generic;

namespace Newtonsoft.Json.Linq
{
	public class JArray : JContainer, IList<JToken>, ICollection<JToken>, IEnumerable<JToken>, IEnumerable
	{
		private readonly List<JToken> _values;

		protected override IList<JToken> ChildrenTokens => null;

		public override JTokenType Type => default(JTokenType);

		public JToken Item
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool IsReadOnly => false;

		public JArray()
		{
		}

		public JArray(JArray other)
		{
		}

		public JArray(object content)
		{
		}

		internal override JToken CloneToken()
		{
			return null;
		}

		public static JArray Load(JsonReader reader, JsonLoadSettings settings)
		{
			return null;
		}

		public override void WriteTo(JsonWriter writer, params JsonConverter[] converters)
		{
		}

		internal override int IndexOfItem(JToken item)
		{
			return 0;
		}

		public int IndexOf(JToken item)
		{
			return 0;
		}

		public void Insert(int index, JToken item)
		{
		}

		public void RemoveAt(int index)
		{
		}

		public IEnumerator<JToken> GetEnumerator()
		{
			return null;
		}

		public void Add(JToken item)
		{
		}

		public void Clear()
		{
		}

		public bool Contains(JToken item)
		{
			return false;
		}

		public void CopyTo(JToken[] array, int arrayIndex)
		{
		}

		public bool Remove(JToken item)
		{
			return false;
		}
	}
}
