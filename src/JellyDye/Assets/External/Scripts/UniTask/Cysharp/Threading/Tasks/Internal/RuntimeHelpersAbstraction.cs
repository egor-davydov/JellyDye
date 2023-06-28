using System;

namespace Cysharp.Threading.Tasks.Internal
{
	internal static class RuntimeHelpersAbstraction
	{
		private static class WellKnownNoReferenceContainsType<T>
		{
			public static readonly bool IsWellKnownType;

			static WellKnownNoReferenceContainsType()
			{
			}
		}

		public static bool IsWellKnownNoReferenceContainsType<T>()
		{
			return false;
		}

		private static bool WellKnownNoReferenceContainsTypeInitialize(Type t)
		{
			return false;
		}
	}
}
