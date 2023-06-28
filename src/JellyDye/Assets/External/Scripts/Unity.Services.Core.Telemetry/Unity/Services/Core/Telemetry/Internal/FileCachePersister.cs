using System.Runtime.CompilerServices;
using UnityEngine;

namespace Unity.Services.Core.Telemetry.Internal
{
	internal abstract class FileCachePersister
	{
		internal static bool IsAvailableFor(RuntimePlatform platform)
		{
			return false;
		}

		internal static string GetPersistentDataPathFor(RuntimePlatform platform)
		{
			return null;
		}
	}
	internal class FileCachePersister<TPayload> : FileCachePersister, ICachePersister<TPayload> where TPayload : ITelemetryPayload
	{
		public string FilePath
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public bool CanPersist
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
		}

		public FileCachePersister(string fileName)
		{
		}

		public void Persist(CachedPayload<TPayload> cache)
		{
		}

		public bool TryFetch(out CachedPayload<TPayload> persistedCache)
		{
			persistedCache = null;
			return false;
		}

		public void Delete()
		{
		}
	}
}
