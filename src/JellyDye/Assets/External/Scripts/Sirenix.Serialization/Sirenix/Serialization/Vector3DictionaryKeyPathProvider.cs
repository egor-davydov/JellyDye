using UnityEngine;

namespace Sirenix.Serialization
{
	public sealed class Vector3DictionaryKeyPathProvider : BaseDictionaryKeyPathProvider<Vector3>
	{
		public override string ProviderID => null;

		public override int Compare(Vector3 x, Vector3 y)
		{
			return 0;
		}

		public override Vector3 GetKeyFromPathString(string pathStr)
		{
			return default(Vector3);
		}

		public override string GetPathStringFromKey(Vector3 key)
		{
			return null;
		}

		public Vector3DictionaryKeyPathProvider()
		{
			((BaseDictionaryKeyPathProvider<>)(object)this)._002Ector();
		}
	}
}
