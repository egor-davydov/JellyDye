using System.Threading.Tasks;
using UnityEngine.Networking;

namespace Unity.Services.Core.Internal
{
	internal static class UnityWebRequestUtils
	{
		public static bool HasSucceeded(this UnityWebRequest self)
		{
			return false;
		}

		public static Task<string> GetTextAsync(string uri)
		{
			return null;
		}
	}
}
