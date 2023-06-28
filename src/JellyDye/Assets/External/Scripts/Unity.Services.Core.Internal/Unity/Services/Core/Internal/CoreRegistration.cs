namespace Unity.Services.Core.Internal
{
	public readonly struct CoreRegistration
	{
		private readonly IPackageRegistry m_Registry;

		private readonly int m_PackageHash;

		internal CoreRegistration(IPackageRegistry registry, int packageHash)
		{
		}

		public CoreRegistration DependsOn<T>() where T : IServiceComponent
		{
			return default(CoreRegistration);
		}

		public CoreRegistration OptionallyDependsOn<T>() where T : IServiceComponent
		{
			return default(CoreRegistration);
		}

		public CoreRegistration ProvidesComponent<T>() where T : IServiceComponent
		{
			return default(CoreRegistration);
		}
	}
}
