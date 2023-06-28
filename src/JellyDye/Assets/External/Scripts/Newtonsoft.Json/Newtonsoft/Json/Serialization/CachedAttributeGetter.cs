using System;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	internal static class CachedAttributeGetter<T> where T : Attribute
	{
		private static readonly ThreadSafeStore<object, T> TypeAttributeCache;

		public static T GetAttribute(object type)
		{
			return null;
		}
	}
}
