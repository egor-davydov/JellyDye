using System;
using System.Collections.Generic;

namespace Cysharp.Threading.Tasks.Linq
{
	internal class AsyncSelectorEnumerableSorter<TElement, TKey> : AsyncEnumerableSorter<TElement>
	{
		private readonly Func<TElement, UniTask<TKey>> keySelector;

		private readonly IComparer<TKey> comparer;

		private readonly bool descending;

		private readonly AsyncEnumerableSorter<TElement> next;

		private TKey[] keys;

		internal AsyncSelectorEnumerableSorter(Func<TElement, UniTask<TKey>> keySelector, IComparer<TKey> comparer, bool descending, AsyncEnumerableSorter<TElement> next)
		{
			((AsyncEnumerableSorter<>)(object)this)._002Ector();
		}

		internal override UniTask ComputeKeysAsync(TElement[] elements, int count)
		{
			return default(UniTask);
		}

		internal override int CompareKeys(int index1, int index2)
		{
			return 0;
		}
	}
}
