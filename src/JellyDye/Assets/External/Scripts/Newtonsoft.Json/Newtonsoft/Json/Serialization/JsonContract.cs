using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Newtonsoft.Json.Serialization
{
	public abstract class JsonContract
	{
		internal bool IsNullable;

		internal bool IsConvertable;

		internal bool IsEnum;

		internal Type NonNullableUnderlyingType;

		internal ReadType InternalReadType;

		internal JsonContractType ContractType;

		internal bool IsReadOnlyOrFixedSize;

		internal bool IsSealed;

		internal bool IsInstantiable;

		private List<SerializationCallback> _onDeserializedCallbacks;

		private List<SerializationCallback> _onDeserializingCallbacks;

		private List<SerializationCallback> _onSerializedCallbacks;

		private List<SerializationCallback> _onSerializingCallbacks;

		private List<SerializationErrorCallback> _onErrorCallbacks;

		private Type _createdType;

		public Type UnderlyingType
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public Type CreatedType
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool? IsReference
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public JsonConverter Converter
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public JsonConverter InternalConverter
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			internal set
			{
			}
		}

		public IList<SerializationCallback> OnDeserializedCallbacks => null;

		public IList<SerializationCallback> OnDeserializingCallbacks => null;

		public IList<SerializationCallback> OnSerializedCallbacks => null;

		public IList<SerializationCallback> OnSerializingCallbacks => null;

		public IList<SerializationErrorCallback> OnErrorCallbacks => null;

		public Func<object> DefaultCreator
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool DefaultCreatorNonPublic
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		internal JsonContract(Type underlyingType)
		{
		}

		internal void InvokeOnSerializing(object o, StreamingContext context)
		{
		}

		internal void InvokeOnSerialized(object o, StreamingContext context)
		{
		}

		internal void InvokeOnDeserializing(object o, StreamingContext context)
		{
		}

		internal void InvokeOnDeserialized(object o, StreamingContext context)
		{
		}

		internal void InvokeOnError(object o, StreamingContext context, ErrorContext errorContext)
		{
		}

		internal static SerializationCallback CreateSerializationCallback(MethodInfo callbackMethodInfo)
		{
			return null;
		}

		internal static SerializationErrorCallback CreateSerializationErrorCallback(MethodInfo callbackMethodInfo)
		{
			return null;
		}
	}
}
