using System;

namespace Cysharp.Threading.Tasks.Internal
{
	internal class ListObserver<T> : IObserver<T>
	{
		private readonly ImmutableList<IObserver<T>> _observers;

		public ListObserver(ImmutableList<IObserver<T>> observers)
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

		internal IObserver<T> Add(IObserver<T> observer)
		{
			return null;
		}

		internal IObserver<T> Remove(IObserver<T> observer)
		{
			return null;
		}
	}
}
