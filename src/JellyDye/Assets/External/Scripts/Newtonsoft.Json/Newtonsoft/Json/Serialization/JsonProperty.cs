using System;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Serialization
{
	public class JsonProperty
	{
		internal Required? _required;

		internal bool _hasExplicitDefaultValue;

		private object _defaultValue;

		private bool _hasGeneratedDefaultValue;

		private string _propertyName;

		internal bool _skipPropertyNameEscape;

		private Type _propertyType;

		internal JsonContract PropertyContract
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

		public string PropertyName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Type DeclaringType
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

		public int? Order
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

		public string UnderlyingName
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

		public IValueProvider ValueProvider
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

		public IAttributeProvider AttributeProvider
		{
			[CompilerGenerated]
			set
			{
			}
		}

		public Type PropertyType
		{
			get
			{
				return null;
			}
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

		public bool Ignored
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

		public bool Readable
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

		public bool Writable
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

		public bool HasMemberAttribute
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

		public object DefaultValue
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Required Required => default(Required);

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

		public NullValueHandling? NullValueHandling
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

		public DefaultValueHandling? DefaultValueHandling
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

		public ReferenceLoopHandling? ReferenceLoopHandling
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

		public ObjectCreationHandling? ObjectCreationHandling
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

		public TypeNameHandling? TypeNameHandling
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

		public Predicate<object> ShouldSerialize
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

		public Predicate<object> ShouldDeserialize
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public Predicate<object> GetIsSpecified
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

		public Action<object, object> SetIsSpecified
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

		public JsonConverter ItemConverter
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

		public bool? ItemIsReference
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

		public TypeNameHandling? ItemTypeNameHandling
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

		public ReferenceLoopHandling? ItemReferenceLoopHandling
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

		internal object GetResolvedDefaultValue()
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}

		internal void WritePropertyName(JsonWriter writer)
		{
		}
	}
}
