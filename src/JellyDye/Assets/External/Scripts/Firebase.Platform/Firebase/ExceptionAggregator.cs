using System;
using System.Collections.Generic;

namespace Firebase
{
	internal class ExceptionAggregator
	{
		[ThreadStatic]
		private static List<Exception> threadLocalExceptions;

		private static List<Exception> Exceptions => null;

		public static Exception GetAndClearPendingExceptions()
		{
			return null;
		}

		public static void ThrowAndClearPendingExceptions()
		{
		}

		public static Exception LogException(Exception exception)
		{
			return null;
		}

		public static void Wrap(Action action)
		{
		}

		public static T Wrap<T>(Func<T> func, T errorValue)
		{
			return default(T);
		}
	}
}
