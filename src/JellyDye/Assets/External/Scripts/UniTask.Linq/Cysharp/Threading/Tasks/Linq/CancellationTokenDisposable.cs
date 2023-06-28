using System;
using System.Threading;

namespace Cysharp.Threading.Tasks.Linq
{
	internal sealed class CancellationTokenDisposable : IDisposable
	{
		private readonly CancellationTokenSource cts;

		public CancellationToken Token => default(CancellationToken);

		public void Dispose()
		{
		}
	}
}
