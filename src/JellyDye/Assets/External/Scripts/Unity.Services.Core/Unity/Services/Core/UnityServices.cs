using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Unity.Services.Core
{
	public static class UnityServices
	{
		internal static IUnityServices Instance
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

		internal static TaskCompletionSource<object> InstantiationCompletion
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

		public static ServicesInitializationState State => default(ServicesInitializationState);

		public static Task InitializeAsync(InitializationOptions options)
		{
			return null;
		}
	}
}
