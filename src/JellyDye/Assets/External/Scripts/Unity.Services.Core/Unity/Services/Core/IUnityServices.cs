using System.Threading.Tasks;

namespace Unity.Services.Core
{
	internal interface IUnityServices
	{
		ServicesInitializationState State { get; }

		InitializationOptions Options { get; }

		Task InitializeAsync(InitializationOptions options);
	}
}
