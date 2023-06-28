using System.Collections.Generic;
using JetBrains.Annotations;

namespace Unity.Services.Core.Internal
{
	internal static class DictionaryExtensions
	{
		public static TDictionary MergeAllowOverride<TDictionary, TKey, TValue>(this TDictionary self, [NotNull] IDictionary<TKey, TValue> dictionary) where TDictionary : IDictionary<TKey, TValue>
		{
			return default(TDictionary);
		}

		public static bool ValueEquals<TKey, TValue>(this IDictionary<TKey, TValue> x, IDictionary<TKey, TValue> y)
		{
			return false;
		}

		public static bool ValueEquals<TKey, TValue, TComparer>(this IDictionary<TKey, TValue> x, IDictionary<TKey, TValue> y, TComparer valueComparer) where TComparer : IEqualityComparer<TValue>
		{
			return false;
		}
	}
}
