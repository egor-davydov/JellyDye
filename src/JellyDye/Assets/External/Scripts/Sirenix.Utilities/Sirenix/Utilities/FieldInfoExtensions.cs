using System.Reflection;

namespace Sirenix.Utilities
{
	public static class FieldInfoExtensions
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
