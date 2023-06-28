using System;
using System.Runtime.InteropServices;
using Grpc.Core.Logging;

namespace Grpc.Core.Internal
{
	internal class UnmanagedLibrary
	{
		private static class Windows
		{
			[PreserveSig]
			internal static extern IntPtr LoadLibrary(string filename);

			[PreserveSig]
			internal static extern IntPtr GetProcAddress(IntPtr hModule, string procName);
		}

		private static class Linux
		{
			[PreserveSig]
			internal static extern IntPtr dlopen(string filename, int flags);

			[PreserveSig]
			internal static extern IntPtr dlerror();

			[PreserveSig]
			internal static extern IntPtr dlsym(IntPtr handle, string symbol);
		}

		private static class MacOSX
		{
			[PreserveSig]
			internal static extern IntPtr dlopen(string filename, int flags);

			[PreserveSig]
			internal static extern IntPtr dlerror();

			[PreserveSig]
			internal static extern IntPtr dlsym(IntPtr handle, string symbol);
		}

		private static class Mono
		{
			[PreserveSig]
			internal static extern IntPtr dlopen(string filename, int flags);

			[PreserveSig]
			internal static extern IntPtr dlerror();

			[PreserveSig]
			internal static extern IntPtr dlsym(IntPtr handle, string symbol);
		}

		private static class CoreCLR
		{
			[PreserveSig]
			internal static extern IntPtr dlopen(string filename, int flags);

			[PreserveSig]
			internal static extern IntPtr dlerror();

			[PreserveSig]
			internal static extern IntPtr dlsym(IntPtr handle, string symbol);
		}

		private static readonly ILogger Logger;

		private readonly string libraryPath;

		private readonly IntPtr handle;

		public UnmanagedLibrary(string[] libraryPathAlternatives)
		{
		}

		private IntPtr LoadSymbol(string symbolName)
		{
			return (IntPtr)0;
		}

		public T GetNativeMethodDelegate<T>(string methodName) where T : class
		{
			return null;
		}

		private static IntPtr PlatformSpecificLoadLibrary(string libraryPath, out string errorMsg)
		{
			errorMsg = null;
			return (IntPtr)0;
		}

		private static IntPtr LoadLibraryPosix(Func<string, int, IntPtr> dlopenFunc, Func<IntPtr> dlerrorFunc, string libraryPath, out string errorMsg)
		{
			errorMsg = null;
			return (IntPtr)0;
		}

		private static string FirstValidLibraryPath(string[] libraryPathAlternatives)
		{
			return null;
		}
	}
}
