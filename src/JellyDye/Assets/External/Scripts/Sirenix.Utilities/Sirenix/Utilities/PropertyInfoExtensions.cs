using System.Reflection;

namespace Sirenix.Utilities
{
	public static class PropertyInfoExtensions
	{
		public static bool IsAutoProperty(this PropertyInfo propInfo)
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
