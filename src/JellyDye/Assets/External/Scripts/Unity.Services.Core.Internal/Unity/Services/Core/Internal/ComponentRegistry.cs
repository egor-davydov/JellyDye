using System.Collections.Generic;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;

namespace Unity.Services.Core.Internal
{
	internal class ComponentRegistry : IComponentRegistry
	{
		[NotNull]
		internal Dictionary<int, IServiceComponent> ComponentTypeHashToInstance
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public ComponentRegistry([NotNull] Dictionary<int, IServiceComponent> componentTypeHashToInstance)
		{
		}

		public void RegisterServiceComponent<TComponent>(TComponent component) where TComponent : IServiceComponent
		{
		}

		public TComponent GetServiceComponent<TComponent>() where TComponent : IServiceComponent
		{
			return default(TComponent);
		}

		private bool IsComponentTypeRegistered(int componentTypeHash)
		{
			return false;
		}

		public void ResetProvidedComponents(IDictionary<int, IServiceComponent> componentTypeHashToInstance)
		{
		}
	}
}
