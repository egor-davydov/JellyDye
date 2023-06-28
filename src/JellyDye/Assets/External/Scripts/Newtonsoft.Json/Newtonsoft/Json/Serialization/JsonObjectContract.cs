using System;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Serialization
{
	public class JsonObjectContract : JsonContainerContract
	{
		internal bool ExtensionDataIsJToken;

		private bool? _hasRequiredOrDefaultValueProperties;

		private ObjectConstructor<object> _overrideCreator;

		private ObjectConstructor<object> _parameterizedCreator;

		private JsonPropertyCollection _creatorParameters;

		private Type _extensionDataValueType;

		public MemberSerialization MemberSerialization
		{
			[CompilerGenerated]
			get
			{
				return default(MemberSerialization);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public MissingMemberHandling? MissingMemberHandling
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

		public Required? ItemRequired
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

		public NullValueHandling? ItemNullValueHandling
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

		public JsonPropertyCollection Properties
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public JsonPropertyCollection CreatorParameters => null;

		public ObjectConstructor<object> OverrideCreator
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal ObjectConstructor<object> ParameterizedCreator
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public ExtensionDataSetter ExtensionDataSetter
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

		public ExtensionDataGetter ExtensionDataGetter
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

		public Type ExtensionDataValueType
		{
			set
			{
			}
		}

		public Func<string, string> ExtensionDataNameResolver
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

		internal bool HasRequiredOrDefaultValueProperties => false;

		public JsonObjectContract(Type underlyingType)
			: base(null)
		{
		}

		internal object GetUninitializedObject()
		{
			return null;
		}
	}
}
