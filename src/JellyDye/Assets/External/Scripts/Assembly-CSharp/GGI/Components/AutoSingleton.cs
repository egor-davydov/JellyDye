using System;

namespace GGI.Components
{
	public class AutoSingleton<T> where T : AutoSingleton<T>
	{
		private static readonly Lazy<T> _instance;

		public static T Instance => null;

		private static T CreateInstanceOfT()
		{
			return null;
		}
	}
}
