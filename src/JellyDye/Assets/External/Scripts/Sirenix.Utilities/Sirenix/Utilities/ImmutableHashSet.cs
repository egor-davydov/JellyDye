using System;
using System.Collections;
using System.Collections.Generic;

namespace Sirenix.Utilities
{
	[Serializable]
	public class ImmutableHashSet<T> : IEnumerable<T>, IEnumerable
	{
		private readonly HashSet<T> hashSet;

		public ImmutableHashSet(HashSet<T> hashSet)
		{
		}

		public bool Contains(T item)
		{
			return false;
		}

		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}
	}
}
