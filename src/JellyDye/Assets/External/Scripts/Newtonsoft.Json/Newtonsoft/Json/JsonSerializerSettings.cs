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
	public class JsonSerializerSettings
	{
		internal static readonly StreamingContext DefaultContext;

		internal static readonly CultureInfo DefaultCulture;

		internal Formatting? _formatting;

		internal DateFormatHandling? _dateFormatHandling;

		internal DateTimeZoneHandling? _dateTimeZoneHandling;

		internal DateParseHandling? _dateParseHandling;

		internal FloatFormatHandling? _floatFormatHandling;

		internal FloatParseHandling? _floatParseHandling;

		internal StringEscapeHandling? _stringEscapeHandling;

		internal CultureInfo _culture;

		internal bool? _checkAdditionalContent;

		internal int? _maxDepth;

		internal bool _maxDepthSet;

		internal string _dateFormatString;

		internal bool _dateFormatStringSet;

		internal TypeNameAssemblyFormatHandling? _typeNameAssemblyFormatHandling;

		internal DefaultValueHandling? _defaultValueHandling;

		internal PreserveReferencesHandling? _preserveReferencesHandling;

		internal NullValueHandling? _nullValueHandling;

		internal ObjectCreationHandling? _objectCreationHandling;

		internal MissingMemberHandling? _missingMemberHandling;

		internal ReferenceLoopHandling? _referenceLoopHandling;

		internal StreamingContext? _context;

		internal ConstructorHandling? _constructorHandling;

		internal TypeNameHandling? _typeNameHandling;

		internal MetadataPropertyHandling? _metadataPropertyHandling;

		public ReferenceLoopHandling ReferenceLoopHandling
		{
			get
			{
				return default(ReferenceLoopHandling);
			}
			set
			{
			}
		}

		public MissingMemberHandling MissingMemberHandling => default(MissingMemberHandling);

		public ObjectCreationHandling ObjectCreationHandling => default(ObjectCreationHandling);

		public NullValueHandling NullValueHandling => default(NullValueHandling);

		public DefaultValueHandling DefaultValueHandling => default(DefaultValueHandling);

		public IList<JsonConverter> Converters
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

		public PreserveReferencesHandling PreserveReferencesHandling => default(PreserveReferencesHandling);

		public TypeNameHandling TypeNameHandling
		{
			get
			{
				return default(TypeNameHandling);
			}
			set
			{
			}
		}

		public MetadataPropertyHandling MetadataPropertyHandling => default(MetadataPropertyHandling);

		public TypeNameAssemblyFormatHandling TypeNameAssemblyFormatHandling => default(TypeNameAssemblyFormatHandling);

		public ConstructorHandling ConstructorHandling => default(ConstructorHandling);

		public IContractResolver ContractResolver
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public IEqualityComparer EqualityComparer
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public Func<IReferenceResolver> ReferenceResolverProvider
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public ITraceWriter TraceWriter
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public ISerializationBinder SerializationBinder
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public EventHandler<ErrorEventArgs> Error
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public StreamingContext Context => default(StreamingContext);

		static JsonSerializerSettings()
		{
		}

		[DebuggerStepThrough]
		public JsonSerializerSettings()
		{
		}
	}
}
