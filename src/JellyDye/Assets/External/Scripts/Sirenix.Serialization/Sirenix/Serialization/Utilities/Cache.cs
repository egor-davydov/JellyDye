using System;

namespace Sirenix.Serialization.Utilities
{
	public sealed class Cache<T> : IDisposable where T : class, new()
	{
		private static readonly bool IsNotificationReceiver;

		private static object[] FreeValues;

		private bool isFree;

		private static int THREAD_LOCK_TOKEN;

		private static int maxCacheSize;

		public T Value;

		public static int MaxCacheSize
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public bool IsFree => false;

		private Cache()
		{
		}

		public static Cache<T> Claim()
		{
			return null;
		}

		public static void Release(Cache<T> cache)
		{
		}

		public static implicit operator T(Cache<T> cache)
		{
			return null;
		}

		public void Release()
		{
		}

		private void System_002EIDisposable_002EDispose()
		{
		}
	}
}
