using System;
using System.Collections.Generic;

namespace Unity.Services.Core.Internal
{
	internal class DependencyTreeSortFailedException : Exception
	{
		public DependencyTreeSortFailedException(DependencyTree tree, ICollection<int> target, Exception inner)
		{
		}

		private static string CreateExceptionMessage(DependencyTree tree, ICollection<int> target, Exception inner = null)
		{
			return null;
		}
	}
}
