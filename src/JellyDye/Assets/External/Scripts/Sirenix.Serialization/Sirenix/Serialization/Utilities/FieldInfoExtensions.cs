using System.Reflection;

namespace Sirenix.Serialization.Utilities
{
	internal static class FieldInfoExtensions
	{
		public static bool IsAliasField(this FieldInfo fieldInfo)
		{
			return false;
		}

		public static FieldInfo DeAliasField(this FieldInfo fieldInfo, bool throwOnNotAliased = false)
		{
			return null;
		}
	}
}
