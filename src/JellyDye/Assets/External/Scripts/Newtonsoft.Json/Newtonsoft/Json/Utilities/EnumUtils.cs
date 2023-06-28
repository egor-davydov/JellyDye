using System;
using Newtonsoft.Json.Serialization;

namespace Newtonsoft.Json.Utilities
{
	internal static class EnumUtils
	{
		private static readonly ThreadSafeStore<StructMultiKey<Type, NamingStrategy>, EnumInfo> ValuesAndNamesPerEnum;

		private static CamelCaseNamingStrategy _camelCaseNamingStrategy;

		private static EnumInfo InitializeValuesAndNames(StructMultiKey<Type, NamingStrategy> key)
		{
			return null;
		}

		public static bool TryToString(Type enumType, object value, NamingStrategy namingStrategy, out string name)
		{
			name = null;
			return false;
		}

		private static string InternalFlagsFormat(EnumInfo entry, ulong result)
		{
			return null;
		}

		public static EnumInfo GetEnumValuesAndNames(Type enumType)
		{
			return null;
		}

		private static ulong ToUInt64(object value)
		{
			return 0uL;
		}

		public static object ParseEnum(Type enumType, NamingStrategy namingStrategy, string value, bool disallowNumber)
		{
			return null;
		}

		private static int? MatchName(string value, string[] enumNames, string[] resolvedNames, int valueIndex, int valueSubstringLength, StringComparison comparison)
		{
			return null;
		}

		private static int? FindIndexByName(string[] enumNames, string value, int valueIndex, int valueSubstringLength, StringComparison comparison)
		{
			return null;
		}
	}
}
