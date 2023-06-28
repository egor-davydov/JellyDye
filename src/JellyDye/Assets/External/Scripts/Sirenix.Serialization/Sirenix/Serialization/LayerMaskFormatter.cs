using UnityEngine;

namespace Sirenix.Serialization
{
	public class LayerMaskFormatter : MinimalBaseFormatter<LayerMask>
	{
		private static readonly Serializer<int> IntSerializer;

		protected override void Read(ref LayerMask value, IDataReader reader)
		{
		}

		protected override void Write(ref LayerMask value, IDataWriter writer)
		{
		}

		public LayerMaskFormatter()
		{
			((MinimalBaseFormatter<>)(object)this)._002Ector();
		}
	}
}
