using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Firebase.Platform;

namespace Firebase
{
	public sealed class FirebaseApp : IDisposable
	{
		public class EnableModuleParams
		{
			public string CppModuleName
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

			public string CSharpClassName
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

			public bool AlwaysEnable
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

			public EnableModuleParams(string csharp, string cpp, bool always = false)
			{
			}
		}

		private delegate FirebaseApp CreateDelegate();

		private HandleRef swigCPtr;

		private bool swigCMemOwn;

		internal static readonly object disposeLock;

		private string name;

		private static Dictionary<string, FirebaseApp> nameToProxy;

		private static Dictionary<IntPtr, FirebaseApp> cPtrToProxy;

		private static bool AppUtilCallbacksInitialized;

		private static object AppUtilCallbacksLock;

		private static bool PreventOnAllAppsDestroyed;

		private static bool crashlyticsInitializationAttempted;

		private static int CheckDependenciesThread;

		private static object CheckDependenciesThreadLock;

		private FirebaseAppPlatform appPlatform;

		public static FirebaseApp DefaultInstance => null;

		public string Name => null;

		public static LogLevel LogLevel => default(LogLevel);

		internal string NameInternal => null;

		public static string DefaultName => null;

		internal event EventHandler AppDisposed
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		internal FirebaseApp(IntPtr cPtr, bool cMemoryOwn)
		{
		}

		internal static HandleRef getCPtr(FirebaseApp obj)
		{
			return default(HandleRef);
		}

		~FirebaseApp()
		{
		}

		public void Dispose()
		{
		}

		public void Dispose(bool disposing)
		{
		}

		static FirebaseApp()
		{
		}

		internal static void TranslateDllNotFoundException(Action closureToExecute)
		{
		}

		public static FirebaseApp GetInstance(string name)
		{
			return null;
		}

		public static FirebaseApp Create()
		{
			return null;
		}

		private void AddReference()
		{
		}

		private void RemoveReference()
		{
		}

		private void ThrowIfNull()
		{
		}

		private static void InitializeAppUtilCallbacks()
		{
		}

		private static void OnAllAppsDestroyed()
		{
		}

		private static bool InitializeCrashlyticsIfPresent()
		{
			return false;
		}

		private static FirebaseApp CreateAndTrack(CreateDelegate createDelegate, FirebaseApp existingProxy)
		{
			return null;
		}

		private static void ThrowIfCheckDependenciesRunning()
		{
		}

		private static bool IsCheckDependenciesRunning()
		{
			return false;
		}

		internal static FirebaseApp CreateInternal()
		{
			return null;
		}

		internal static void ReleaseReferenceInternal(FirebaseApp app)
		{
		}

		internal static void RegisterLibraryInternal(string library, string version)
		{
		}

		internal static void AppSetDefaultConfigPath(string path)
		{
		}
	}
}
