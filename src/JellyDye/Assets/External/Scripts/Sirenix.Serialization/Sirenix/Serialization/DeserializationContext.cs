using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Sirenix.Serialization.Utilities;

namespace Sirenix.Serialization
{
	public sealed class DeserializationContext : ICacheNotificationReceiver
	{
		private SerializationConfig config;

		private Dictionary<int, object> internalIdReferenceMap;

		private StreamingContext streamingContext;

		private IFormatterConverter formatterConverter;

		private TwoWaySerializationBinder binder;

		public TwoWaySerializationBinder Binder
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public IExternalStringReferenceResolver StringReferenceResolver
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

		public IExternalGuidReferenceResolver GuidReferenceResolver
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

		public IExternalIndexReferenceResolver IndexReferenceResolver
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

		public StreamingContext StreamingContext => default(StreamingContext);

		public IFormatterConverter FormatterConverter => null;

		public SerializationConfig Config
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public DeserializationContext()
		{
		}

		public DeserializationContext(StreamingContext context)
		{
		}

		public DeserializationContext(FormatterConverter formatterConverter)
		{
		}

		public DeserializationContext(StreamingContext context, FormatterConverter formatterConverter)
		{
		}

		public void RegisterInternalReference(int id, object reference)
		{
		}

		public object GetInternalReference(int id)
		{
			return null;
		}

		public object GetExternalObject(int index)
		{
			return null;
		}

		public object GetExternalObject(Guid guid)
		{
			return null;
		}

		public object GetExternalObject(string id)
		{
			return null;
		}

		public void Reset()
		{
		}

		private void Sirenix_002ESerialization_002EUtilities_002EICacheNotificationReceiver_002EOnFreed()
		{
		}

		private void Sirenix_002ESerialization_002EUtilities_002EICacheNotificationReceiver_002EOnClaimed()
		{
		}
	}
}
