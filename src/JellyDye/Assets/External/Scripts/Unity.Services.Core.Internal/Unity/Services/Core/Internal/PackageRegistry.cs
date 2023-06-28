using System.Runtime.CompilerServices;
using JetBrains.Annotations;

namespace Unity.Services.Core.Internal
{
	internal class PackageRegistry : IPackageRegistry
	{
		public DependencyTree Tree
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

		public PackageRegistry([CanBeNull] DependencyTree tree)
		{
		}

		public CoreRegistration RegisterPackage<TPackage>(TPackage package) where TPackage : IInitializablePackage
		{
			return default(CoreRegistration);
		}

		public void RegisterDependency<TComponent>(int packageTypeHash) where TComponent : IServiceComponent
		{
		}

		public void RegisterOptionalDependency<TComponent>(int packageTypeHash) where TComponent : IServiceComponent
		{
		}

		public void RegisterProvision<TComponent>(int packageTypeHash) where TComponent : IServiceComponent
		{
		}

		private void AddComponentDependencyToPackage(int componentTypeHash, int packageTypeHash)
		{
		}
	}
}
