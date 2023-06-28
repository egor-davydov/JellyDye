using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace Newtonsoft.Json.Linq
{
	public class JProperty : JContainer
	{
		private class JPropertyList : IList<JToken>, ICollection<JToken>, IEnumerable<JToken>, IEnumerable
		{
			internal JToken _token;

			public int Count => 0;

			public bool IsReadOnly => false;

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

			public IEnumerator<JToken> GetEnumerator()
			{
				return null;
			}

			private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
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
		}

		private readonly JPropertyList _content;

		private readonly string _name;

		protected override IList<JToken> ChildrenTokens => null;

		public string Name
		{
			[DebuggerStepThrough]
			get
			{
				return null;
			}
		}

		public JToken Value
		{
			[DebuggerStepThrough]
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override JTokenType Type
		{
			[DebuggerStepThrough]
			get
			{
				return default(JTokenType);
			}
		}

		public JProperty(JProperty other)
		{
		}

		internal override JToken GetItem(int index)
		{
			return null;
		}

		internal override void SetItem(int index, JToken item)
		{
		}

		internal override bool RemoveItem(JToken item)
		{
			return false;
		}

		internal override void RemoveItemAt(int index)
		{
		}

		internal override int IndexOfItem(JToken item)
		{
			return 0;
		}

		internal override bool InsertItem(int index, JToken item, bool skipParentCheck)
		{
			return false;
		}

		internal override bool ContainsItem(JToken item)
		{
			return false;
		}

		internal override void ClearItems()
		{
		}

		internal override JToken CloneToken()
		{
			return null;
		}

		internal JProperty(string name)
		{
		}

		public JProperty(string name, object content)
		{
		}

		public override void WriteTo(JsonWriter writer, params JsonConverter[] converters)
		{
		}

		public static JProperty Load(JsonReader reader, JsonLoadSettings settings)
		{
			return null;
		}
	}
}
