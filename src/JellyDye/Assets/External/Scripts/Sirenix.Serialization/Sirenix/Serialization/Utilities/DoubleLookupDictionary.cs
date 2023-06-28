using System;
using System.Collections.Generic;

namespace Sirenix.Serialization.Utilities
{
	[Serializable]
	internal class DoubleLookupDictionary<TFirstKey, TSecondKey, TValue> : Dictionary<TFirstKey, Dictionary<TSecondKey, TValue>>
	{
		private readonly IEqualityComparer<TSecondKey> secondKeyComparer;

		public new Dictionary<TSecondKey, TValue> Item => null;

		public DoubleLookupDictionary()
		{
			((Dictionary<TKey, TValue>)(object)this)._002Ector();
		}

		public DoubleLookupDictionary(IEqualityComparer<TFirstKey> firstKeyComparer, IEqualityComparer<TSecondKey> secondKeyComparer)
		{
			((Dictionary<TKey, TValue>)(object)this)._002Ector();
		}

		public int InnerCount(TFirstKey firstKey)
		{
			return 0;
		}

		public int TotalInnerCount()
		{
			return 0;
		}

		public bool ContainsKeys(TFirstKey firstKey, TSecondKey secondKey)
		{
			return false;
		}

		public bool TryGetInnerValue(TFirstKey firstKey, TSecondKey secondKey, out TValue value)
		{
			value = default(TValue);
			return false;
		}

		public TValue AddInner(TFirstKey firstKey, TSecondKey secondKey, TValue value)
		{
			return default(TValue);
		}

		public bool RemoveInner(TFirstKey firstKey, TSecondKey secondKey)
		{
			return false;
		}

		public void RemoveWhere(Func<TValue, bool> predicate)
		{
		}
	}
}
