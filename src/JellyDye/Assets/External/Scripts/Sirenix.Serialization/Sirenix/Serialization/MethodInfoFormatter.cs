using System;
using System.Reflection;

namespace Sirenix.Serialization
{
	public sealed class MethodInfoFormatter<T> : BaseFormatter<T> where T : MethodInfo
	{
		private static readonly Serializer<string> StringSerializer;

		private static readonly Serializer<Type> TypeSerializer;

		private static readonly Serializer<Type[]> TypeArraySerializer;

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

		public MethodInfoFormatter()
		{
			((BaseFormatter<>)(object)this)._002Ector();
		}
	}
}
