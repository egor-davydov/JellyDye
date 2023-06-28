using UnityEngine;

namespace GGI.Components
{
	public static class AutoInitialize
	{
		[RuntimeInitializeOnLoadMethod]
		public static void OnLoadBeforeScene()
		{
		}
	}
}
