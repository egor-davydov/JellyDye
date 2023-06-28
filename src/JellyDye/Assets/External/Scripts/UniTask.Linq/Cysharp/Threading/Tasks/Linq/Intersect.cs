using System;
using System.Collections.Generic;
using System.Threading;

namespace Cysharp.Threading.Tasks.Linq
{
	internal sealed class Intersect<TSource> : IUniTaskAsyncEnumerable<TSource>
	{
		private class _Intersect : AsyncEnumeratorBase<TSource, TSource>
		{
			private static Action<object> HashSetAsyncCoreDelegate;

			private readonly IEqualityComparer<TSource> comparer;

			private readonly IUniTaskAsyncEnumerable<TSource> second;

			private HashSet<TSource> set;

			private UniTask<HashSet<TSource>>.Awaiter awaiter;

			public _Intersect(IUniTaskAsyncEnumerable<TSource> first, IUniTaskAsyncEnumerable<TSource> second, IEqualityComparer<TSource> comparer, CancellationToken cancellationToken)
			{
				((AsyncEnumeratorBase<, >)(object)this)._002Ector((IUniTaskAsyncEnumerable<TSource>)null, default(CancellationToken));
			}

			protected override bool OnFirstIteration()
			{
				return false;
			}

			private static void HashSetAsyncCore(object state)
			{
			}

			protected override bool TryMoveNextCore(bool sourceHasCurrent, out bool result)
			{
				result = default(bool);
				return false;
			}
		}

		private readonly IUniTaskAsyncEnumerable<TSource> first;

		private readonly IUniTaskAsyncEnumerable<TSource> second;

		private readonly IEqualityComparer<TSource> comparer;

		public Intersect(IUniTaskAsyncEnumerable<TSource> first, IUniTaskAsyncEnumerable<TSource> second, IEqualityComparer<TSource> comparer)
		{
		}

		public IUniTaskAsyncEnumerator<TSource> GetAsyncEnumerator(CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}
	}
}
