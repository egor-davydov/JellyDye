using System.Collections.Generic;

namespace Sirenix.Serialization
{
	public abstract class BaseDictionaryKeyPathProvider<T> : IDictionaryKeyPathProvider<T>, IDictionaryKeyPathProvider, IComparer<T>
	{
		public abstract string ProviderID { get; }

		public abstract T GetKeyFromPathString(string pathStr);

		public abstract string GetPathStringFromKey(T key);

		public abstract int Compare(T x, T y);

		private int Sirenix_002ESerialization_002EIDictionaryKeyPathProvider_002ECompare(object x, object y)
		{
			return 0;
		}

		private object Sirenix_002ESerialization_002EIDictionaryKeyPathProvider_002EGetKeyFromPathString(string pathStr)
		{
			return null;
		}

		private string Sirenix_002ESerialization_002EIDictionaryKeyPathProvider_002EGetPathStringFromKey(object key)
		{
			return null;
		}
	}
}
