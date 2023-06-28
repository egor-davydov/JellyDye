using GGI.Components;

namespace GGI.Internal.Storage
{
	public class UnityStorage : AutoSingleton<UnityStorage>
	{
		public void SetString(string key, string value)
		{
		}

		public void SetInt(string key, int value)
		{
		}

		public void SetFloat(string key, float value)
		{
		}

		public string GetString(string key, string def = "")
		{
			return null;
		}

		public int GetInt(string key, int def = 0)
		{
			return 0;
		}

		public float GetFloat(string key, float def = 0f)
		{
			return 0f;
		}

		public bool HasKey(string key)
		{
			return false;
		}

		public void Delete(string key)
		{
		}

		public UnityStorage()
		{
			((AutoSingleton<>)(object)this)._002Ector();
		}
	}
}
