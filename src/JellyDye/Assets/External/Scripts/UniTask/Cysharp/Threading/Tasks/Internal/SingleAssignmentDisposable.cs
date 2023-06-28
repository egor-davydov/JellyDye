using System;

namespace Cysharp.Threading.Tasks.Internal
{
	internal sealed class SingleAssignmentDisposable : IDisposable
	{
		private readonly object gate;

		private IDisposable current;

		private bool disposed;

		public bool IsDisposed => false;

		public IDisposable Disposable
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public void Dispose()
		{
		}
	}
}
