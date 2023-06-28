using UnityEngine;

namespace Sirenix.Serialization
{
	public sealed class Vector2DictionaryKeyPathProvider : BaseDictionaryKeyPathProvider<Vector2>
	{
		public override string ProviderID => null;

		public override int Compare(Vector2 x, Vector2 y)
		{
			return 0;
		}

		public override Vector2 GetKeyFromPathString(string pathStr)
		{
			return default(Vector2);
		}

		public override string GetPathStringFromKey(Vector2 key)
		{
			return null;
		}

		public Vector2DictionaryKeyPathProvider()
		{
			((BaseDictionaryKeyPathProvider<>)(object)this)._002Ector();
		}
	}
}
