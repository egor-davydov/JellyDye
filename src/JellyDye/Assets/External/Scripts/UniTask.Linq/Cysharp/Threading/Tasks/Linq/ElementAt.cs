using System.Threading;

namespace Cysharp.Threading.Tasks.Linq
{
	internal static class ElementAt
	{
		public static UniTask<TSource> ElementAtAsync<TSource>(IUniTaskAsyncEnumerable<TSource> source, int index, CancellationToken cancellationToken, bool defaultIfEmpty)
		{
			return default(UniTask<TSource>);
		}
	}
}
