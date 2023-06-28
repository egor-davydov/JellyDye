using System;
using Grpc.Core.Logging;

namespace Grpc.Core.Internal
{
	internal class NativeCallbackDispatcher
	{
		private static readonly ILogger Logger;

		private static NativeCallbackDispatcherCallback dispatcherCallback;

		public static void Init(NativeMethods native)
		{
		}

		public static NativeCallbackRegistration RegisterCallback(UniversalNativeCallback callback)
		{
			return null;
		}

		private static int HandleDispatcherCallback(IntPtr tag, IntPtr arg0, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5)
		{
			return 0;
		}
	}
}
