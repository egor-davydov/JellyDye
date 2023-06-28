using System;

namespace Cysharp.Threading.Tasks.Internal
{
	internal class EmptyDisposable : IDisposable
	{
		public static EmptyDisposable Instance;

		private EmptyDisposable()
		{
		}

		public void Dispose()
		{
		}
	}
}
