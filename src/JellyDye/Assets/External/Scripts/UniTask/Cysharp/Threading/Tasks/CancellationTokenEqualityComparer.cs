using System.Collections.Generic;
using System.Threading;

namespace Cysharp.Threading.Tasks
{
	public class CancellationTokenEqualityComparer : IEqualityComparer<CancellationToken>
	{
		public static readonly IEqualityComparer<CancellationToken> Default;

		public bool Equals(CancellationToken x, CancellationToken y)
		{
			return false;
		}

		public int GetHashCode(CancellationToken obj)
		{
			return 0;
		}
	}
}
