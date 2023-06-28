using System;

namespace Sirenix.Serialization
{
	public sealed class DelegateFormatter<T> : BaseFormatter<T> where T : class
	{
		private static readonly Serializer<object> ObjectSerializer;

		private static readonly Serializer<string> StringSerializer;

		private static readonly Serializer<Type> TypeSerializer;

		private static readonly Serializer<Type[]> TypeArraySerializer;

		private static readonly Serializer<Delegate[]> DelegateArraySerializer;

		static DelegateFormatter()
		{
		}

		protected override void DeserializeImplementation(ref T value, IDataReader reader)
		{
		}

		protected override void SerializeImplementation(ref T value, IDataWriter writer)
		{
		}

		protected override T GetUninitializedObject()
		{
			return null;
		}

		public DelegateFormatter()
		{
			((BaseFormatter<>)(object)this)._002Ector();
		}
	}
}
