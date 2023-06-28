using Grpc.Core.Logging;

namespace Grpc.Core.Internal
{
	internal sealed class NativeExtension
	{
		private static readonly ILogger Logger;

		private static readonly object staticLock;

		private static NativeExtension instance;

		private readonly NativeMethods nativeMethods;

		public NativeMethods NativeMethods => null;

		private NativeExtension()
		{
		}

		public static NativeExtension Get()
		{
			return null;
		}

		private static NativeMethods LoadNativeMethodsUsingExplicitLoad()
		{
			return null;
		}

		private static NativeMethods LoadNativeMethodsUsingDllImports()
		{
			return null;
		}

		private static NativeMethods LoadNativeMethods()
		{
			return null;
		}

		private static NativeMethods LoadNativeMethodsUnity()
		{
			return null;
		}

		private static NativeMethods LoadNativeMethodsXamarin()
		{
			return null;
		}

		private static string GetAssemblyDirectory()
		{
			return null;
		}

		private static bool IsNet5SingleFileApp()
		{
			return false;
		}

		private static bool IsFileUri(string uri)
		{
			return false;
		}

		private static string GetRuntimeIdString()
		{
			return null;
		}

		private static string GetArchitectureString()
		{
			return null;
		}

		private static string GetNativeLibraryFilename()
		{
			return null;
		}
	}
}
