using System;
using System.Threading;

namespace Cysharp.Threading.Tasks.Linq
{
	internal sealed class SkipWhileInt<TSource> : IUniTaskAsyncEnumerable<TSource>
	{
		private class _SkipWhileInt : AsyncEnumeratorBase<TSource, TSource>
		{
			private Func<TSource, int, bool> predicate;

			private int index;

			public _SkipWhileInt(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, int, bool> predicate, CancellationToken cancellationToken)
			{
				((AsyncEnumeratorBase<, >)(object)this)._002Ector((IUniTaskAsyncEnumerable<TSource>)null, default(CancellationToken));
			}

			protected override bool TryMoveNextCore(bool sourceHasCurrent, out bool result)
			{
				result = default(bool);
				return false;
			}
		}

		private readonly IUniTaskAsyncEnumerable<TSource> source;

		private readonly Func<TSource, int, bool> predicate;

		public SkipWhileInt(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, int, bool> predicate)
		{
		}

		public IUniTaskAsyncEnumerator<TSource> GetAsyncEnumerator(CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}
	}
}
