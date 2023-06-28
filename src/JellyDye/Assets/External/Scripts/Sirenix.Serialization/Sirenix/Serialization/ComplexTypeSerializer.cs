using System;
using System.Collections.Generic;

namespace Sirenix.Serialization
{
	public sealed class ComplexTypeSerializer<T> : Serializer<T>
	{
		private static readonly bool ComplexTypeMayBeBoxedValueType;

		private static readonly bool ComplexTypeIsAbstract;

		private static readonly bool ComplexTypeIsNullable;

		private static readonly bool ComplexTypeIsValueType;

		private static readonly Type TypeOf_T;

		private static readonly bool AllowDeserializeInvalidDataForT;

		private static readonly Dictionary<ISerializationPolicy, IFormatter<T>> FormattersByPolicy;

		private static readonly object FormattersByPolicy_LOCK;

		private static readonly ISerializationPolicy UnityPolicy;

		private static readonly ISerializationPolicy StrictPolicy;

		private static readonly ISerializationPolicy EverythingPolicy;

		private static IFormatter<T> UnityPolicyFormatter;

		private static IFormatter<T> StrictPolicyFormatter;

		private static IFormatter<T> EverythingPolicyFormatter;

		public override T ReadValue(IDataReader reader)
		{
			return default(T);
		}

		private static IFormatter<T> GetBaseFormatter(ISerializationPolicy serializationPolicy)
		{
			return null;
		}

		public override void WriteValue(string name, T value, IDataWriter writer)
		{
		}

		public ComplexTypeSerializer()
		{
			((Serializer<>)(object)this)._002Ector();
		}
	}
}
