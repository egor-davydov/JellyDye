using System.Collections.Generic;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;

namespace Unity.Services.Core.Internal
{
	internal class LockedComponentRegistry : IComponentRegistry
	{
		[NotNull]
		internal IComponentRegistry Registry
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public LockedComponentRegistry([NotNull] IComponentRegistry registryToLock)
		{
		}

		public void RegisterServiceComponent<TComponent>(TComponent component) where TComponent : IServiceComponent
		{
		}

		public TComponent GetServiceComponent<TComponent>() where TComponent : IServiceComponent
		{
			return default(TComponent);
		}

		public void ResetProvidedComponents(IDictionary<int, IServiceComponent> componentTypeHashToInstance)
		{
		}
	}
}
