using UnityEngine;

namespace Unity.Services.Core.Internal
{
	internal static class UnityServicesInitializer
	{
		[RuntimeInitializeOnLoadMethod]
		private static void CreateStaticInstance()
		{
		}

		[RuntimeInitializeOnLoadMethod]
		private static void EnableServicesInitializationAsync()
		{
		}
	}
}
