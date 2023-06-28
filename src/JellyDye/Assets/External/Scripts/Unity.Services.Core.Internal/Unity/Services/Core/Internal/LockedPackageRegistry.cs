using System.Runtime.CompilerServices;
using JetBrains.Annotations;

namespace Unity.Services.Core.Internal
{
	internal class LockedPackageRegistry : IPackageRegistry
	{
		[NotNull]
		internal IPackageRegistry Registry
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public DependencyTree Tree
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public LockedPackageRegistry([NotNull] IPackageRegistry registryToLock)
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
	}
}
