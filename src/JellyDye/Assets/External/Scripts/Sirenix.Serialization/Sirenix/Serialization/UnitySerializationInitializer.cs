using System.Runtime.CompilerServices;
using UnityEngine;

namespace Sirenix.Serialization
{
	public static class UnitySerializationInitializer
	{
		private static readonly object LOCK;

		private static bool initialized;

		public static bool Initialized => false;

		public static RuntimePlatform CurrentPlatform
		{
			[CompilerGenerated]
			get
			{
				return default(RuntimePlatform);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public static void Initialize()
		{
		}

		[RuntimeInitializeOnLoadMethod]
		private static void InitializeRuntime()
		{
		}

		private static void InitializeEditor()
		{
		}
	}
}
