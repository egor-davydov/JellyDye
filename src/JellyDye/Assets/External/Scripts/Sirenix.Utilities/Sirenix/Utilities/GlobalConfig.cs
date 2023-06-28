using UnityEngine;

namespace Sirenix.Utilities
{
	public abstract class GlobalConfig<T> : ScriptableObject where T : GlobalConfig<T>, new()
	{
		private static GlobalConfigAttribute configAttribute;

		private static T instance;

		private static GlobalConfigAttribute ConfigAttribute => null;

		public static bool HasInstanceLoaded => false;

		public static T Instance => null;

		public static void LoadInstanceIfAssetExists()
		{
		}

		public void OpenInEditor()
		{
		}

		protected virtual void OnConfigAutoCreated()
		{
		}
	}
}
