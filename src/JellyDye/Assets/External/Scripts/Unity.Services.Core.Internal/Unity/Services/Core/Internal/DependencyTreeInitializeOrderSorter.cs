using System.Collections.Generic;

namespace Unity.Services.Core.Internal
{
	internal struct DependencyTreeInitializeOrderSorter
	{
		private enum ExplorationMark
		{
			None = 0,
			Viewed = 1,
			Sorted = 2
		}

		public readonly DependencyTree Tree;

		public readonly ICollection<int> Target;

		private Dictionary<int, ExplorationMark> m_PackageTypeHashExplorationHistory;

		public DependencyTreeInitializeOrderSorter(DependencyTree tree, ICollection<int> target)
		{
		}

		public void SortRegisteredPackagesIntoTarget()
		{
		}

		private void RemoveUnprovidedOptionalDependenciesFromTree()
		{
		}

		private void RemoveUnprovidedOptionalDependencies(IList<int> dependencyTypeHashes)
		{
		}

		private void SortTreeThrough(int packageTypeHash)
		{
		}

		private void SortTreeThrough(IEnumerable<int> dependencyTypeHashes)
		{
		}

		private void MarkPackage(int packageTypeHash, ExplorationMark mark)
		{
		}

		private IReadOnlyCollection<int> GetPackageTypeHashes()
		{
			return null;
		}

		private int GetPackageTypeHashFor(int componentTypeHash)
		{
			return 0;
		}

		private IEnumerable<int> GetDependencyTypeHashesFor(int packageTypeHash)
		{
			return null;
		}
	}
}
