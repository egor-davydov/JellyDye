using System;
using System.Collections.Generic;
using System.Reflection;

namespace Sirenix.Utilities
{
	public static class MemberInfoExtensions
	{
		public static bool IsDefined<T>(this ICustomAttributeProvider member, bool inherit) where T : Attribute
		{
			return false;
		}

		public static bool IsDefined<T>(this ICustomAttributeProvider member) where T : Attribute
		{
			return false;
		}

		public static T GetAttribute<T>(this ICustomAttributeProvider member, bool inherit) where T : Attribute
		{
			return null;
		}

		public static T GetAttribute<T>(this ICustomAttributeProvider member) where T : Attribute
		{
			return null;
		}

		public static IEnumerable<T> GetAttributes<T>(this ICustomAttributeProvider member) where T : Attribute
		{
			return null;
		}

		public static IEnumerable<T> GetAttributes<T>(this ICustomAttributeProvider member, bool inherit) where T : Attribute
		{
			return null;
		}

		public static Attribute[] GetAttributes(this ICustomAttributeProvider member)
		{
			return null;
		}

		public static Attribute[] GetAttributes(this ICustomAttributeProvider member, bool inherit)
		{
			return null;
		}

		public static string GetNiceName(this MemberInfo member)
		{
			return null;
		}

		public static bool IsStatic(this MemberInfo member)
		{
			return false;
		}

		public static bool IsAlias(this MemberInfo memberInfo)
		{
			return false;
		}

		public static MemberInfo DeAlias(this MemberInfo memberInfo, bool throwOnNotAliased = false)
		{
			return null;
		}

		public static bool SignaturesAreEqual(this MemberInfo a, MemberInfo b)
		{
			return false;
		}
	}
}
