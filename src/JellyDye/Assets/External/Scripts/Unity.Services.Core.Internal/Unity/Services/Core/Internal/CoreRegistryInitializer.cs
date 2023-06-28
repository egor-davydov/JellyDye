using System.Collections.Generic;
using System.Threading.Tasks;
using JetBrains.Annotations;

namespace Unity.Services.Core.Internal
{
	internal class CoreRegistryInitializer
	{
		[NotNull]
		private readonly CoreRegistry m_Registry;

		[NotNull]
		private readonly List<int> m_SortedPackageTypeHashes;

		public CoreRegistryInitializer([NotNull] CoreRegistry registry, [NotNull] List<int> sortedPackageTypeHashes)
		{
		}

		public Task InitializeRegistryAsync()
		{
			return null;
		}
	}
}
