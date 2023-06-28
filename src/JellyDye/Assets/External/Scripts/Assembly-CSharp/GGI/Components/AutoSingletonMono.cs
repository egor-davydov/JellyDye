using System.Diagnostics;

namespace GGI.Components
{
	public class AutoSingletonMono<T> : GGIMonoBehaviour where T : AutoSingletonMono<T>
	{
		private static T _instance;

		public static T Instance
		{
			[DebuggerStepThrough]
			get
			{
				return null;
			}
		}

		protected virtual void Awake()
		{
		}

		private void OnApplicationQuit()
		{
		}
	}
}
