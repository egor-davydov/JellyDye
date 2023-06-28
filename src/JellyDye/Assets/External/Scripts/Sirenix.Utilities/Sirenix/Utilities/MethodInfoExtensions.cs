using System.Reflection;

namespace Sirenix.Utilities
{
	public static class MethodInfoExtensions
	{
		public static string GetFullName(this MethodBase method, string extensionMethodPrefix)
		{
			return null;
		}

		public static string GetParamsNames(this MethodBase method)
		{
			return null;
		}

		public static string GetFullName(this MethodBase method)
		{
			return null;
		}

		public static bool IsExtensionMethod(this MethodBase method)
		{
			return false;
		}

		public static bool IsAliasMethod(this MethodInfo methodInfo)
		{
			return false;
		}

		public static MethodInfo DeAliasMethod(this MethodInfo methodInfo, bool throwOnNotAliased = false)
		{
			return null;
		}
	}
}
