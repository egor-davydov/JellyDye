using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Newtonsoft.Json.Serialization;

namespace Newtonsoft.Json
{
	public class JsonSerializer
	{
		internal TypeNameHandling _typeNameHandling;

		internal TypeNameAssemblyFormatHandling _typeNameAssemblyFormatHandling;

		internal PreserveReferencesHandling _preserveReferencesHandling;

		internal ReferenceLoopHandling _referenceLoopHandling;

		internal MissingMemberHandling _missingMemberHandling;

		internal ObjectCreationHandling _objectCreationHandling;

		internal NullValueHandling _nullValueHandling;

		internal DefaultValueHandling _defaultValueHandling;

		internal ConstructorHandling _constructorHandling;

		internal MetadataPropertyHandling _metadataPropertyHandling;

		internal JsonConverterCollection _converters;

		internal IContractResolver _contractResolver;

		internal ITraceWriter _traceWriter;

		internal IEqualityComparer _equalityComparer;

		internal ISerializationBinder _serializationBinder;

		internal StreamingContext _context;

		private IReferenceResolver _referenceResolver;

		private Formatting? _formatting;

		private DateFormatHandling? _dateFormatHandling;

		private DateTimeZoneHandling? _dateTimeZoneHandling;

		private DateParseHandling? _dateParseHandling;

		private FloatFormatHandling? _floatFormatHandling;

		private FloatParseHandling? _floatParseHandling;

		private StringEscapeHandling? _stringEscapeHandling;

		private CultureInfo _culture;

		private int? _maxDepth;

		private bool _maxDepthSet;

		private bool? _checkAdditionalContent;

		private string _dateFormatString;

		private bool _dateFormatStringSet;

		public virtual IReferenceResolver ReferenceResolver
		{
			set
			{
			}
		}

		public virtual ISerializationBinder SerializationBinder
		{
			set
			{
			}
		}

		public virtual ITraceWriter TraceWriter
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public virtual IEqualityComparer EqualityComparer
		{
			set
			{
			}
		}

		public virtual TypeNameHandling TypeNameHandling
		{
			set
			{
			}
		}

		public virtual TypeNameAssemblyFormatHandling TypeNameAssemblyFormatHandling
		{
			set
			{
			}
		}

		public virtual PreserveReferencesHandling PreserveReferencesHandling
		{
			set
			{
			}
		}

		public virtual ReferenceLoopHandling ReferenceLoopHandling
		{
			set
			{
			}
		}

		public virtual MissingMemberHandling MissingMemberHandling
		{
			set
			{
			}
		}

		public virtual NullValueHandling NullValueHandling
		{
			get
			{
				return default(NullValueHandling);
			}
			set
			{
			}
		}

		public virtual DefaultValueHandling DefaultValueHandling
		{
			set
			{
			}
		}

		public virtual ObjectCreationHandling ObjectCreationHandling
		{
			set
			{
			}
		}

		public virtual ConstructorHandling ConstructorHandling
		{
			set
			{
			}
		}

		public virtual MetadataPropertyHandling MetadataPropertyHandling
		{
			get
			{
				return default(MetadataPropertyHandling);
			}
			set
			{
			}
		}

		public virtual JsonConverterCollection Converters => null;

		public virtual IContractResolver ContractResolver
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public virtual StreamingContext Context
		{
			get
			{
				return default(StreamingContext);
			}
			set
			{
			}
		}

		public virtual Formatting Formatting
		{
			get
			{
				return default(Formatting);
			}
			set
			{
			}
		}

		public virtual bool CheckAdditionalContent
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public virtual event EventHandler<ErrorEventArgs> Error
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		internal bool IsCheckAdditionalContentSet()
		{
			return false;
		}

		public static JsonSerializer Create()
		{
			return null;
		}

		public static JsonSerializer Create(JsonSerializerSettings settings)
		{
			return null;
		}

		public static JsonSerializer CreateDefault()
		{
			return null;
		}

		public static JsonSerializer CreateDefault(JsonSerializerSettings settings)
		{
			return null;
		}

		private static void ApplySerializerSettings(JsonSerializer serializer, JsonSerializerSettings settings)
		{
		}

		[DebuggerStepThrough]
		public void Populate(JsonReader reader, object target)
		{
		}

		internal virtual void PopulateInternal(JsonReader reader, object target)
		{
		}

		[DebuggerStepThrough]
		public T Deserialize<T>(JsonReader reader)
		{
			return default(T);
		}

		[DebuggerStepThrough]
		public object Deserialize(JsonReader reader, Type objectType)
		{
			return null;
		}

		internal virtual object DeserializeInternal(JsonReader reader, Type objectType)
		{
			return null;
		}

		private void SetupReader(JsonReader reader, out CultureInfo previousCulture, out DateTimeZoneHandling? previousDateTimeZoneHandling, out DateParseHandling? previousDateParseHandling, out FloatParseHandling? previousFloatParseHandling, out int? previousMaxDepth, out string previousDateFormatString)
		{
			previousCulture = null;
			previousDateTimeZoneHandling = null;
			previousDateParseHandling = null;
			previousFloatParseHandling = null;
			previousMaxDepth = null;
			previousDateFormatString = null;
		}

		private void ResetReader(JsonReader reader, CultureInfo previousCulture, DateTimeZoneHandling? previousDateTimeZoneHandling, DateParseHandling? previousDateParseHandling, FloatParseHandling? previousFloatParseHandling, int? previousMaxDepth, string previousDateFormatString)
		{
		}

		public void Serialize(JsonWriter jsonWriter, object value, Type objectType)
		{
		}

		public void Serialize(JsonWriter jsonWriter, object value)
		{
		}

		private TraceJsonReader CreateTraceJsonReader(JsonReader reader)
		{
			return null;
		}

		internal virtual void SerializeInternal(JsonWriter jsonWriter, object value, Type objectType)
		{
		}

		internal IReferenceResolver GetReferenceResolver()
		{
			return null;
		}

		internal JsonConverter GetMatchingConverter(Type type)
		{
			return null;
		}

		internal static JsonConverter GetMatchingConverter(IList<JsonConverter> converters, Type objectType)
		{
			return null;
		}

		internal void OnError(ErrorEventArgs e)
		{
		}
	}
}
