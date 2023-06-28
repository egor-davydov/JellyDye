using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Newtonsoft.Json.Linq
{
	internal class JPropertyKeyedCollection : Collection<JToken>
	{
		private static readonly IEqualityComparer<string> Comparer;

		private Dictionary<string, JToken> _dictionary;

		public ICollection<string> Keys => null;

		public JPropertyKeyedCollection()
		{
			((Collection<T>)(object)this)._002Ector();
		}

		private void AddKey(string key, JToken item)
		{
		}

		protected override void ClearItems()
		{
		}

		public bool Contains(string key)
		{
			return false;
		}

		private void EnsureDictionary()
		{
		}

		private string GetKeyForItem(JToken item)
		{
			return null;
		}

		protected override void InsertItem(int index, JToken item)
		{
		}

		protected override void RemoveItem(int index)
		{
		}

		private void RemoveKey(string key)
		{
		}

		protected override void SetItem(int index, JToken item)
		{
		}

		public bool TryGetValue(string key, out JToken value)
		{
			value = null;
			return false;
		}

		public int IndexOfReference(JToken t)
		{
			return 0;
		}
	}
}
