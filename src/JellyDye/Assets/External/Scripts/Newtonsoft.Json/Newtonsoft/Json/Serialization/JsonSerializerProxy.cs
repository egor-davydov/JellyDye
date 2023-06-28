using System;
using System.Collections;
using System.Runtime.Serialization;

namespace Newtonsoft.Json.Serialization
{
	internal class JsonSerializerProxy : JsonSerializer
	{
		private readonly JsonSerializerInternalReader _serializerReader;

		private readonly JsonSerializerInternalWriter _serializerWriter;

		private readonly JsonSerializer _serializer;

		public override IReferenceResolver ReferenceResolver
		{
			set
			{
			}
		}

		public override ITraceWriter TraceWriter
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override IEqualityComparer EqualityComparer
		{
			set
			{
			}
		}

		public override JsonConverterCollection Converters => null;

		public override DefaultValueHandling DefaultValueHandling
		{
			set
			{
			}
		}

		public override IContractResolver ContractResolver
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override MissingMemberHandling MissingMemberHandling
		{
			set
			{
			}
		}

		public override NullValueHandling NullValueHandling
		{
			get
			{
				return default(NullValueHandling);
			}
			set
			{
			}
		}

		public override ObjectCreationHandling ObjectCreationHandling
		{
			set
			{
			}
		}

		public override ReferenceLoopHandling ReferenceLoopHandling
		{
			set
			{
			}
		}

		public override PreserveReferencesHandling PreserveReferencesHandling
		{
			set
			{
			}
		}

		public override TypeNameHandling TypeNameHandling
		{
			set
			{
			}
		}

		public override MetadataPropertyHandling MetadataPropertyHandling
		{
			get
			{
				return default(MetadataPropertyHandling);
			}
			set
			{
			}
		}

		public override TypeNameAssemblyFormatHandling TypeNameAssemblyFormatHandling
		{
			set
			{
			}
		}

		public override ConstructorHandling ConstructorHandling
		{
			set
			{
			}
		}

		public override ISerializationBinder SerializationBinder
		{
			set
			{
			}
		}

		public override StreamingContext Context
		{
			get
			{
				return default(StreamingContext);
			}
			set
			{
			}
		}

		public override Formatting Formatting
		{
			get
			{
				return default(Formatting);
			}
			set
			{
			}
		}

		public override bool CheckAdditionalContent
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public override event EventHandler<ErrorEventArgs> Error
		{
			add
			{
			}
			remove
			{
			}
		}

		internal JsonSerializerInternalBase GetInternalSerializer()
		{
			return null;
		}

		public JsonSerializerProxy(JsonSerializerInternalReader serializerReader)
		{
		}

		public JsonSerializerProxy(JsonSerializerInternalWriter serializerWriter)
		{
		}

		internal override object DeserializeInternal(JsonReader reader, Type objectType)
		{
			return null;
		}

		internal override void PopulateInternal(JsonReader reader, object target)
		{
		}

		internal override void SerializeInternal(JsonWriter jsonWriter, object value, Type rootType)
		{
		}
	}
}
