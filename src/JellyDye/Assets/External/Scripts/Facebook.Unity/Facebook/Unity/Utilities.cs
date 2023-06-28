using System;
using System.Collections.Generic;

namespace Facebook.Unity
{
	internal static class Utilities
	{
		public delegate void Callback<T>(T obj);

		public static bool TryGetValue<T>(this IDictionary<string, object> dictionary, string key, out T value)
		{
			value = default(T);
			return false;
		}

		public static long TotalSeconds(this DateTime dateTime)
		{
			return 0L;
		}

		public static T GetValueOrDefault<T>(this IDictionary<string, object> dictionary, string key, bool logWarning = true)
		{
			return default(T);
		}

		public static string ToCommaSeparateList(this IEnumerable<string> list)
		{
			return null;
		}

		public static string AbsoluteUrlOrEmptyString(this Uri uri)
		{
			return null;
		}

		public static string GetUserAgent(string productName, string productVersion)
		{
			return null;
		}

		public static string ToJson(this IDictionary<string, object> dictionary)
		{
			return null;
		}

		public static void AddAllKVPFrom<T1, T2>(this IDictionary<T1, T2> dest, IDictionary<T1, T2> source)
		{
		}

		public static AccessToken ParseAccessTokenFromResult(IDictionary<string, object> resultDictionary)
		{
			return null;
		}

		public static AuthenticationToken ParseAuthenticationTokenFromResult(IDictionary<string, object> resultDictionary)
		{
			return null;
		}

		public static string ToStringNullOk(this object obj)
		{
			return null;
		}

		public static string FormatToString(string baseString, string className, IDictionary<string, string> propertiesAndValues)
		{
			return null;
		}

		private static DateTime ParseExpirationDateFromResult(IDictionary<string, object> resultDictionary)
		{
			return default(DateTime);
		}

		private static DateTime? ParseLastRefreshFromResult(IDictionary<string, object> resultDictionary)
		{
			return null;
		}

		private static ICollection<string> ParsePermissionFromResult(IDictionary<string, object> resultDictionary)
		{
			return null;
		}

		public static IList<Product> ParseCatalogFromResult(IDictionary<string, object> resultDictionary)
		{
			return null;
		}

		public static Product ParseProductFromCatalogResult(IDictionary<string, object> product, bool isWindows = false)
		{
			return null;
		}

		public static IList<Purchase> ParsePurchasesFromResult(IDictionary<string, object> resultDictionary)
		{
			return null;
		}

		public static Purchase ParsePurchaseFromResult(IDictionary<string, object> resultDictionary)
		{
			return null;
		}

		public static Purchase ParsePurchaseFromDictionary(IDictionary<string, object> purchase, bool isWindows = false)
		{
			return null;
		}

		public static IDictionary<string, string> ParseStringDictionaryFromString(string input)
		{
			return null;
		}

		public static IDictionary<string, string> ParseInnerStringDictionary(IDictionary<string, object> resultDictionary, string key)
		{
			return null;
		}

		public static DateTime FromTimestamp(int timestamp)
		{
			return default(DateTime);
		}
	}
}
