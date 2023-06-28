using System;
using UnityEngine;

namespace Sirenix.Utilities
{
	public static class UnityExtensions
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
