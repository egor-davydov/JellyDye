using System;
using System.Collections.Generic;
using System.Threading;

namespace Cysharp.Threading.Tasks.Linq
{
	internal class AsyncSelectorWithCancellationEnumerableSorter<TElement, TKey> : AsyncEnumerableSorter<TElement>
	{
		private readonly Func<TElement, CancellationToken, UniTask<TKey>> keySelector;

		private readonly IComparer<TKey> comparer;

		private readonly bool descending;

		private readonly AsyncEnumerableSorter<TElement> next;

		private CancellationToken cancellationToken;

		private TKey[] keys;

		internal AsyncSelectorWithCancellationEnumerableSorter(Func<TElement, CancellationToken, UniTask<TKey>> keySelector, IComparer<TKey> comparer, bool descending, AsyncEnumerableSorter<TElement> next, CancellationToken cancellationToken)
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
