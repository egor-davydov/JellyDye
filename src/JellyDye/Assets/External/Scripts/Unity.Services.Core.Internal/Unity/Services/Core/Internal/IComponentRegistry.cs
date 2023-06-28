using System.Collections.Generic;
using JetBrains.Annotations;

namespace Unity.Services.Core.Internal
{
	internal interface IComponentRegistry
	{
		void RegisterServiceComponent<TComponent>([NotNull] TComponent component) where TComponent : IServiceComponent;

		TComponent GetServiceComponent<TComponent>() where TComponent : IServiceComponent;

		void ResetProvidedComponents(IDictionary<int, IServiceComponent> componentTypeHashToInstance);
	}
}
