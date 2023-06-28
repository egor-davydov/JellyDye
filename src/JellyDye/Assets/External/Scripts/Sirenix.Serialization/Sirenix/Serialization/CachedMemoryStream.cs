using System.IO;
using Sirenix.Serialization.Utilities;

namespace Sirenix.Serialization
{
	internal sealed class CachedMemoryStream : ICacheNotificationReceiver
	{
		public static int InitialCapacity;

		public static int MaxCapacity;

		private MemoryStream memoryStream;

		public MemoryStream MemoryStream => null;

		public void OnFreed()
		{
		}

		public void OnClaimed()
		{
		}

		public static Cache<CachedMemoryStream> Claim(int minCapacity)
		{
			return null;
		}

		public static Cache<CachedMemoryStream> Claim(byte[] bytes = null)
		{
			return null;
		}
	}
}
