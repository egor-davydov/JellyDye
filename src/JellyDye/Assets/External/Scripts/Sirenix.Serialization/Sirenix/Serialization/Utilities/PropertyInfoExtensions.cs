using System.Reflection;

namespace Sirenix.Serialization.Utilities
{
	internal static class PropertyInfoExtensions
	{
		public static bool IsAutoProperty(this PropertyInfo propInfo, bool allowVirtual = false)
		{
			return false;
		}

		public static bool IsAliasProperty(this PropertyInfo propertyInfo)
		{
			return false;
		}

		public static PropertyInfo DeAliasProperty(this PropertyInfo propertyInfo, bool throwOnNotAliased = false)
		{
			return null;
		}
	}
}
