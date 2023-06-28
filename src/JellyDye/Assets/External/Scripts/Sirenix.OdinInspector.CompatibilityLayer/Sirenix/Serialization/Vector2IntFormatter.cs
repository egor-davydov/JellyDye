using UnityEngine;

namespace Sirenix.Serialization
{
	public class Vector2IntFormatter : MinimalBaseFormatter<Vector2Int>
	{
		private static readonly Serializer<int> Serializer;

		protected override void Read(ref Vector2Int value, IDataReader reader)
		{
		}

		protected override void Write(ref Vector2Int value, IDataWriter writer)
		{
		}

		public Vector2IntFormatter()
		{
			((MinimalBaseFormatter<T>)(object)this)._002Ector();
		}
	}
}
