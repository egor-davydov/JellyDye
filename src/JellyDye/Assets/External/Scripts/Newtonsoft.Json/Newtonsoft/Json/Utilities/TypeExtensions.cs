using System;
using System.Reflection;

namespace Newtonsoft.Json.Utilities
{
	internal static class TypeExtensions
	{
		public static MemberTypes MemberType(this MemberInfo memberInfo)
		{
			return default(MemberTypes);
		}

		public static bool ContainsGenericParameters(this Type type)
		{
			return false;
		}

		public static bool IsInterface(this Type type)
		{
			return false;
		}

		public static bool IsGenericType(this Type type)
		{
			return false;
		}

		public static bool IsGenericTypeDefinition(this Type type)
		{
			return false;
		}

		public static Type BaseType(this Type type)
		{
			return null;
		}

		public static Assembly Assembly(this Type type)
		{
			return null;
		}

		public static bool IsEnum(this Type type)
		{
			return false;
		}

		public static bool IsClass(this Type type)
		{
			return false;
		}

		public static bool IsSealed(this Type type)
		{
			return false;
		}

		public static bool IsAbstract(this Type type)
		{
			return false;
		}

		public static bool IsVisible(this Type type)
		{
			return false;
		}

		public static bool IsValueType(this Type type)
		{
			return false;
		}

		public static bool AssignableToTypeName(this Type type, string fullTypeName, bool searchInterfaces, out Type match)
		{
			match = null;
			return false;
		}

		public static bool AssignableToTypeName(this Type type, string fullTypeName, bool searchInterfaces)
		{
			return false;
		}

		public static bool ImplementInterface(this Type type, Type interfaceType)
		{
			return false;
		}
	}
}
