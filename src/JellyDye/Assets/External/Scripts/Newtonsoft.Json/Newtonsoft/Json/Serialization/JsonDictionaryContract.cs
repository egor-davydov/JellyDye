using System;
using System.Collections;
using System.Reflection;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	public class JsonDictionaryContract : JsonContainerContract
	{
		private readonly Type _genericCollectionDefinitionType;

		private Type _genericWrapperType;

		private ObjectConstructor<object> _genericWrapperCreator;

		private Func<object> _genericTemporaryDictionaryCreator;

		private readonly ConstructorInfo _parameterizedConstructor;

		private ObjectConstructor<object> _overrideCreator;

		private ObjectConstructor<object> _parameterizedCreator;

		public Func<string, string> DictionaryKeyResolver
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

		public Type DictionaryKeyType
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public Type DictionaryValueType
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		internal JsonContract KeyContract
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

		internal bool ShouldCreateWrapper
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
		}

		internal ObjectConstructor<object> ParameterizedCreator => null;

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

		public bool HasParameterizedCreator
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

		internal bool HasParameterizedCreatorInternal => false;

		public JsonDictionaryContract(Type underlyingType)
			: base(null)
		{
		}

		internal IWrappedDictionary CreateWrapper(object dictionary)
		{
			return null;
		}

		internal IDictionary CreateTemporaryDictionary()
		{
			return null;
		}
	}
}
