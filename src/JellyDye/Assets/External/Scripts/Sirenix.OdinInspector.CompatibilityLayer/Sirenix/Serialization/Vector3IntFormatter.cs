using UnityEngine;

namespace Sirenix.Serialization
{
	public class Vector3IntFormatter : MinimalBaseFormatter<Vector3Int>
	{
		private static readonly Serializer<int> Serializer;

		protected override void Read(ref Vector3Int value, IDataReader reader)
		{
		}

		protected override void Write(ref Vector3Int value, IDataWriter writer)
		{
		}

		public Vector3IntFormatter()
		{
			((MinimalBaseFormatter<T>)(object)this)._002Ector();
		}
	}
}
