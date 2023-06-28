using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace Unity.Services.Core.Internal
{
	internal static class DependencyTreeExtensions
	{
		internal static string ToJson(this DependencyTree tree, ICollection<int> order = null)
		{
			return null;
		}

		internal static bool IsOptional(this DependencyTree tree, int componentTypeHash)
		{
			return false;
		}

		internal static bool IsProvided(this DependencyTree tree, int componentTypeHash)
		{
			return false;
		}

		private static JObject GetPackageJObject(DependencyTree tree, int packageHash)
		{
			return null;
		}

		private static JObject GetComponentJObject(DependencyTree tree, int componentHash)
		{
			return null;
		}

		private static string GetComponentIdentifier(IServiceComponent component)
		{
			return null;
		}
	}
}
