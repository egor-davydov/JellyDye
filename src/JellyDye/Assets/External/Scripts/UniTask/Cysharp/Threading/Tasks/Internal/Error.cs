using System;
using System.Runtime.CompilerServices;

namespace Cysharp.Threading.Tasks.Internal
{
	internal static class Error
	{
		[MethodImpl(256)]
		public static void ThrowArgumentNullException<T>(T value, string paramName) where T : class
		{
		}

		[MethodImpl(8)]
		private static void ThrowArgumentNullExceptionCore(string paramName)
		{
		}

		[MethodImpl(256)]
		public static Exception ArgumentOutOfRange(string paramName)
		{
			return null;
		}

		[MethodImpl(256)]
		public static Exception NoElements()
		{
			return null;
		}

		[MethodImpl(256)]
		public static Exception MoreThanOneElement()
		{
			return null;
		}

		[MethodImpl(8)]
		public static void ThrowArgumentException<T>(string message)
		{
		}

		[MethodImpl(8)]
		public static void ThrowNotYetCompleted()
		{
		}

		[MethodImpl(8)]
		public static T ThrowNotYetCompleted<T>()
		{
			return default(T);
		}

		[MethodImpl(256)]
		public static void ThrowWhenContinuationIsAlreadyRegistered<T>(T continuationField) where T : class
		{
		}

		[MethodImpl(8)]
		private static void ThrowInvalidOperationExceptionCore(string message)
		{
		}

		[MethodImpl(8)]
		public static void ThrowOperationCanceledException()
		{
		}
	}
}
