using System.Runtime.CompilerServices;
using JetBrains.Annotations;

namespace Unity.Services.Core.Internal
{
	public sealed class CoreRegistry
	{
		public static CoreRegistry Instance
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			internal set
			{
			}
		}

		[NotNull]
		internal IPackageRegistry PackageRegistry
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		[NotNull]
		internal IComponentRegistry ComponentRegistry
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		internal CoreRegistry()
		{
		}

		public CoreRegistration RegisterPackage<TPackage>([NotNull] TPackage package) where TPackage : IInitializablePackage
		{
			return default(CoreRegistration);
		}

		public void RegisterServiceComponent<TComponent>([NotNull] TComponent component) where TComponent : IServiceComponent
		{
		}

		public TComponent GetServiceComponent<TComponent>() where TComponent : IServiceComponent
		{
			return default(TComponent);
		}

		internal void LockPackageRegistration()
		{
		}

		internal void LockComponentRegistration()
		{
		}
	}
}
