using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Firebase.RemoteConfig
{
	public sealed class FirebaseRemoteConfig
	{
		private static readonly Dictionary<string, FirebaseRemoteConfig> remoteConfigByInstanceKey;

		private FirebaseRemoteConfigInternal remoteConfigInternal;

		private readonly FirebaseApp firebaseApp;

		private string instanceKey;

		public static FirebaseRemoteConfig DefaultInstance => null;

		public ConfigInfo Info => null;

		private FirebaseRemoteConfig(FirebaseRemoteConfigInternal remoteConfig, FirebaseApp app)
		{
		}

		~FirebaseRemoteConfig()
		{
		}

		private void Dispose()
		{
		}

		private void OnAppDisposed(object sender, EventArgs eventArgs)
		{
		}

		private void ThrowIfNull()
		{
		}

		public static FirebaseRemoteConfig GetInstance(FirebaseApp app)
		{
			return null;
		}

		private static FirebaseRemoteConfig FindByKey(string instanceKey)
		{
			return null;
		}

		public Task<bool> ActivateAsync()
		{
			return null;
		}

		public Task FetchAsync(TimeSpan cacheExpiration)
		{
			return null;
		}

		public Task SetDefaultsAsync(IDictionary<string, object> defaults)
		{
			return null;
		}

		public ConfigValue GetValue(string key)
		{
			return default(ConfigValue);
		}
	}
}
