using UnityEngine;

namespace Sirenix.Serialization
{
	public sealed class Vector4DictionaryKeyPathProvider : BaseDictionaryKeyPathProvider<Vector4>
	{
		public override string ProviderID => null;

		public override int Compare(Vector4 x, Vector4 y)
		{
			return 0;
		}

		public override Vector4 GetKeyFromPathString(string pathStr)
		{
			return default(Vector4);
		}

		public override string GetPathStringFromKey(Vector4 key)
		{
			return null;
		}

		public Vector4DictionaryKeyPathProvider()
		{
			((BaseDictionaryKeyPathProvider<>)(object)this)._002Ector();
		}
	}
}
