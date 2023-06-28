using System;
using System.Collections.Generic;
using System.Reflection;

namespace Sirenix.Serialization
{
	public static class DictionaryKeyUtility
	{
		private class UnityObjectKeyComparer<T> : IComparer<T>
		{
			public int Compare(T x, T y)
			{
				return 0;
			}
		}

		private class FallbackKeyComparer<T> : IComparer<T>
		{
			public int Compare(T x, T y)
			{
				return 0;
			}
		}

		public class KeyComparer<T> : IComparer<T>
		{
			public static readonly KeyComparer<T> Default;

			private readonly IComparer<T> actualComparer;

			public int Compare(T x, T y)
			{
				return 0;
			}
		}

		private static readonly Dictionary<Type, bool> GetSupportedDictionaryKeyTypesResults;

		private static readonly HashSet<Type> BaseSupportedDictionaryKeyTypes;

		private static readonly HashSet<char> AllowedSpecialKeyStrChars;

		private static readonly Dictionary<Type, IDictionaryKeyPathProvider> TypeToKeyPathProviders;

		private static readonly Dictionary<string, IDictionaryKeyPathProvider> IDToKeyPathProviders;

		private static readonly Dictionary<IDictionaryKeyPathProvider, string> ProviderToID;

		private static readonly Dictionary<object, string> ObjectsToTempKeys;

		private static readonly Dictionary<string, object> TempKeysToObjects;

		private static long tempKeyCounter;

		static DictionaryKeyUtility()
		{
		}

		private static void LogInvalidKeyPathProvider(Type type, Assembly assembly, string reason)
		{
		}

		public static IEnumerable<Type> GetPersistentPathKeyTypes()
		{
			return null;
		}

		public static bool KeyTypeSupportsPersistentPaths(Type type)
		{
			return false;
		}

		private static bool PrivateIsSupportedDictionaryKeyType(Type type)
		{
			return false;
		}

		public static string GetDictionaryKeyString(object key)
		{
			return null;
		}

		public static object GetDictionaryKeyValue(string keyStr, Type expectedType)
		{
			return null;
		}

		private static string FromTo(this string str, int from, int to)
		{
			return null;
		}
	}
}
