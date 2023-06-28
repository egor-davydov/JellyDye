using System.Threading;
using UnityEngine;

namespace Cysharp.Threading.Tasks
{
	public static class UniTaskCancellationExtensions
	{
		public static CancellationToken GetCancellationTokenOnDestroy(this GameObject gameObject)
		{
			return default(CancellationToken);
		}

		public static CancellationToken GetCancellationTokenOnDestroy(this Component component)
		{
			return default(CancellationToken);
		}
	}
}
