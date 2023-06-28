using System.Runtime.CompilerServices;
using System.Threading;

namespace Cysharp.Threading.Tasks.Linq
{
	internal sealed class Reverse<TSource> : IUniTaskAsyncEnumerable<TSource>
	{
		private sealed class _Reverse : MoveNextSource, IUniTaskAsyncEnumerator<TSource>, IUniTaskAsyncDisposable
		{
			private readonly IUniTaskAsyncEnumerable<TSource> source;

			private CancellationToken cancellationToken;

			private TSource[] array;

			private int index;

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

			public _Reverse(IUniTaskAsyncEnumerable<TSource> source, CancellationToken cancellationToken)
			{
			}

			public UniTask<bool> MoveNextAsync()
			{
				return default(UniTask<bool>);
			}

			public UniTask DisposeAsync()
			{
				return default(UniTask);
			}
		}

		private readonly IUniTaskAsyncEnumerable<TSource> source;

		public Reverse(IUniTaskAsyncEnumerable<TSource> source)
		{
		}

		public IUniTaskAsyncEnumerator<TSource> GetAsyncEnumerator(CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}
	}
}
