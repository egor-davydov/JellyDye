using System;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Cysharp.Threading.Tasks.Linq
{
	internal sealed class AppendPrepend<TSource> : IUniTaskAsyncEnumerable<TSource>
	{
		private sealed class _AppendPrepend : MoveNextSource, IUniTaskAsyncEnumerator<TSource>, IUniTaskAsyncDisposable
		{
			private enum State : byte
			{
				None = 0,
				RequirePrepend = 1,
				RequireAppend = 2,
				Completed = 3
			}

			private static readonly Action<object> MoveNextCoreDelegate;

			private readonly IUniTaskAsyncEnumerable<TSource> source;

			private readonly TSource element;

			private CancellationToken cancellationToken;

			private State state;

			private IUniTaskAsyncEnumerator<TSource> enumerator;

			private UniTask<bool>.Awaiter awaiter;

			public TSource Current
			{
				[CompilerGenerated]
				get
				{
					return default(TSource);
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public _AppendPrepend(IUniTaskAsyncEnumerable<TSource> source, TSource element, bool append, CancellationToken cancellationToken)
			{
			}

			public UniTask<bool> MoveNextAsync()
			{
				return default(UniTask<bool>);
			}

			private static void MoveNextCore(object state)
			{
			}

			public UniTask DisposeAsync()
			{
				return default(UniTask);
			}
		}

		private readonly IUniTaskAsyncEnumerable<TSource> source;

		private readonly TSource element;

		private readonly bool append;

		public AppendPrepend(IUniTaskAsyncEnumerable<TSource> source, TSource element, bool append)
		{
		}

		public IUniTaskAsyncEnumerator<TSource> GetAsyncEnumerator(CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}
	}
}
