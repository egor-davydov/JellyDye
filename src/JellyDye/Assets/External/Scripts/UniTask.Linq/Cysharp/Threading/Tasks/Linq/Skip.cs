using System.Threading;

namespace Cysharp.Threading.Tasks.Linq
{
	internal sealed class Skip<TSource> : IUniTaskAsyncEnumerable<TSource>
	{
		private sealed class _Skip : AsyncEnumeratorBase<TSource, TSource>
		{
			private readonly int count;

			private int index;

			public _Skip(IUniTaskAsyncEnumerable<TSource> source, int count, CancellationToken cancellationToken)
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

		private readonly int count;

		public Skip(IUniTaskAsyncEnumerable<TSource> source, int count)
		{
		}

		public IUniTaskAsyncEnumerator<TSource> GetAsyncEnumerator(CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}
	}
}
