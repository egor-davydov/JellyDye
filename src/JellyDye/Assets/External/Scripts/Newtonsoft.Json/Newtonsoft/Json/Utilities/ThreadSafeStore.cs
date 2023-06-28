using System;
using System.Collections.Concurrent;

namespace Newtonsoft.Json.Utilities
{
	internal class ThreadSafeStore<TKey, TValue>
	{
		private readonly ConcurrentDictionary<TKey, TValue> _concurrentStore;

		private readonly Func<TKey, TValue> _creator;

		public ThreadSafeStore(Func<TKey, TValue> creator)
		{
		}

		public TValue Get(TKey key)
		{
			return default(TValue);
		}
	}
}
