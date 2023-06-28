using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Sirenix.Serialization.Utilities;

namespace Sirenix.Serialization
{
	public sealed class SerializationContext : ICacheNotificationReceiver
	{
		private SerializationConfig config;

		private Dictionary<object, int> internalReferenceIdMap;

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

		public StreamingContext StreamingContext => default(StreamingContext);

		public IFormatterConverter FormatterConverter => null;

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

		public SerializationContext()
		{
		}

		public SerializationContext(StreamingContext context)
		{
		}

		public SerializationContext(FormatterConverter formatterConverter)
		{
		}

		public SerializationContext(StreamingContext context, FormatterConverter formatterConverter)
		{
		}

		public bool TryGetInternalReferenceId(object reference, out int id)
		{
			id = default(int);
			return false;
		}

		public bool TryRegisterInternalReference(object reference, out int id)
		{
			id = default(int);
			return false;
		}

		public bool TryRegisterExternalReference(object obj, out int index)
		{
			index = default(int);
			return false;
		}

		public bool TryRegisterExternalReference(object obj, out Guid guid)
		{
			guid = default(Guid);
			return false;
		}

		public bool TryRegisterExternalReference(object obj, out string id)
		{
			id = null;
			return false;
		}

		public void ResetInternalReferences()
		{
		}

		public void ResetToDefault()
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
