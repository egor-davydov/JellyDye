using System;
using System.Runtime.Serialization;

namespace Sirenix.Serialization
{
	public sealed class SerializableFormatter<T> : BaseFormatter<T> where T : ISerializable
	{
		private static readonly Func<SerializationInfo, StreamingContext, T> ISerializableConstructor;

		private static readonly ReflectionFormatter<T> ReflectionFormatter;

		static SerializableFormatter()
		{
		}

		protected override T GetUninitializedObject()
		{
			return default(T);
		}

		protected override void DeserializeImplementation(ref T value, IDataReader reader)
		{
		}

		protected override void SerializeImplementation(ref T value, IDataWriter writer)
		{
		}

		private SerializationInfo ReadSerializationInfo(IDataReader reader)
		{
			return null;
		}

		private void WriteSerializationInfo(SerializationInfo info, IDataWriter writer)
		{
		}

		public SerializableFormatter()
		{
			((BaseFormatter<>)(object)this)._002Ector();
		}
	}
}
