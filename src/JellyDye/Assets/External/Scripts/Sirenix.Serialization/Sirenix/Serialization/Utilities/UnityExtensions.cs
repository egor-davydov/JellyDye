using System;
using UnityEngine;

namespace Sirenix.Serialization.Utilities
{
	internal static class UnityExtensions
	{
		private static readonly ValueGetter<UnityEngine.Object, IntPtr> UnityObjectCachedPtrFieldGetter;

		static UnityExtensions()
		{
		}

		public static bool SafeIsUnityNull(this UnityEngine.Object obj)
		{
			return false;
		}
	}
}
