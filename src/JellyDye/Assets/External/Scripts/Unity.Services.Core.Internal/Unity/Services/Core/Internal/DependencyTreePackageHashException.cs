using System;

namespace Unity.Services.Core.Internal
{
	internal class DependencyTreePackageHashException : HashException
	{
		public DependencyTreePackageHashException(int hash, string message)
			: base(0, null)
		{
		}

		public DependencyTreePackageHashException(int hash, string message, Exception inner)
			: base(0, null)
		{
		}
	}
}
