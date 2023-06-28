using System;
using System.Runtime.CompilerServices;

namespace Unity.Services.Core.Internal
{
	internal class MissingComponent : IServiceComponent
	{
		public Type IntendedType
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		internal MissingComponent(Type intendedType)
		{
		}
	}
}
