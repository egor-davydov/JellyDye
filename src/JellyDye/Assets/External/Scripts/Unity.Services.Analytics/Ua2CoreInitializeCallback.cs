using System.Threading.Tasks;
using Unity.Services.Core.Internal;
using UnityEngine;

internal class Ua2CoreInitializeCallback : IInitializablePackage
{
	[RuntimeInitializeOnLoadMethod]
	private static void Register()
	{
	}

	public Task Initialize(CoreRegistry registry)
	{
		return null;
	}
}
