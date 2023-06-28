using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.Serialization;

namespace Sirenix.Serialization
{
	public abstract class BaseFormatter<T> : IFormatter<T>, IFormatter
	{
		protected delegate void SerializationCallback(ref T value, StreamingContext context);

		protected static readonly SerializationCallback[] OnSerializingCallbacks;

		protected static readonly SerializationCallback[] OnSerializedCallbacks;

		protected static readonly SerializationCallback[] OnDeserializingCallbacks;

		protected static readonly SerializationCallback[] OnDeserializedCallbacks;

		protected static readonly bool IsValueType;

		protected static readonly bool ImplementsISerializationCallbackReceiver;

		protected static readonly bool ImplementsIDeserializationCallback;

		protected static readonly bool ImplementsIObjectReference;

		public Type SerializedType => null;

		static BaseFormatter()
		{
		}

		private static SerializationCallback[] GetCallbacks(MethodInfo[] methods, Type callbackAttribute, ref List<SerializationCallback> list)
		{
			return null;
		}

		private static SerializationCallback CreateCallback(MethodInfo info)
		{
			return null;
		}

		private void Sirenix_002ESerialization_002EIFormatter_002ESerialize(object value, IDataWriter writer)
		{
		}

		private object Sirenix_002ESerialization_002EIFormatter_002EDeserialize(IDataReader reader)
		{
			return null;
		}

		public T Deserialize(IDataReader reader)
		{
			return default(T);
		}

		public void Serialize(T value, IDataWriter writer)
		{
		}

		protected virtual T GetUninitializedObject()
		{
			return default(T);
		}

		protected void RegisterReferenceID(T value, IDataReader reader)
		{
		}

		[Obsolete]
		protected void InvokeOnDeserializingCallbacks(T value, DeserializationContext context)
		{
		}

		protected void InvokeOnDeserializingCallbacks(ref T value, DeserializationContext context)
		{
		}

		protected abstract void DeserializeImplementation(ref T value, IDataReader reader);

		protected abstract void SerializeImplementation(ref T value, IDataWriter writer);
	}
}
