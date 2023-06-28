using System;

namespace Cysharp.Threading.Tasks.Internal
{
	internal class EmptyObserver<T> : IObserver<T>
	{
		public static readonly EmptyObserver<T> Instance;

		private EmptyObserver()
		{
		}

		public void OnCompleted()
		{
		}

		public void OnError(Exception error)
		{
		}

		public void OnNext(T value)
		{
		}
	}
}
