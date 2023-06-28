using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Firebase.Platform
{
	internal sealed class FirebaseHandler
	{
		internal class ApplicationFocusChangedEventArgs : EventArgs
		{
			public bool HasFocus
			{
				[CompilerGenerated]
				set
				{
				}
			}
		}

		private static FirebaseMonoBehaviour firebaseMonoBehaviour;

		private static int tickCount;

		private static FirebaseHandler firebaseHandler;

		[CompilerGenerated]
		private EventHandler<EventArgs> Updated;

		internal Action UpdatedEventWrapper;

		[CompilerGenerated]
		private EventHandler<ApplicationFocusChangedEventArgs> ApplicationFocusChanged;

		public static IFirebaseAppUtils AppUtils
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public static int TickCount => 0;

		private static Dispatcher ThreadDispatcher
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool IsPlayMode
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		internal static FirebaseHandler DefaultInstance => null;

		static FirebaseHandler()
		{
		}

		private FirebaseHandler()
		{
		}

		internal void StartMonoBehaviour()
		{
		}

		internal void StopMonoBehaviour()
		{
		}

		public static TResult RunOnMainThread<TResult>(Func<TResult> f)
		{
			return default(TResult);
		}

		public static Task<TResult> RunOnMainThreadAsync<TResult>(Func<TResult> f)
		{
			return null;
		}

		internal static void CreatePartialOnMainThread(IFirebaseAppUtils appUtils)
		{
		}

		internal static void Create(IFirebaseAppUtils appUtils)
		{
		}

		internal void Update()
		{
		}

		internal void OnApplicationFocus(bool hasFocus)
		{
		}

		internal static void OnMonoBehaviourDestroyed(FirebaseMonoBehaviour behaviour)
		{
		}
	}
}
