using System;

namespace Firebase.Platform
{
	internal class MainThreadProperty<T>
	{
		private Func<T> getPropertyDelegate;

		private int lastGetPropertyTickCount;

		private T cachedValue;

		public T Value => default(T);

		public MainThreadProperty(Func<T> getPropertyDelegate)
		{
		}
	}
}
