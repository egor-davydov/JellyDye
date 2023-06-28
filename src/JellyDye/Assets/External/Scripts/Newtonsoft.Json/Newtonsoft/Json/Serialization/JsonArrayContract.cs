using System;
using System.Collections;
using System.Reflection;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	public class JsonArrayContract : JsonContainerContract
	{
		private readonly Type _genericCollectionDefinitionType;

		private Type _genericWrapperType;

		private ObjectConstructor<object> _genericWrapperCreator;

		private Func<object> _genericTemporaryCollectionCreator;

		private readonly ConstructorInfo _parameterizedConstructor;

		private ObjectConstructor<object> _parameterizedCreator;

		private ObjectConstructor<object> _overrideCreator;

		public Type CollectionItemType
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public bool IsMultidimensionalArray
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
		}

		internal bool IsArray
		{
			[CompilerGenerated]
			get
			{
				return false;
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

		internal bool CanDeserialize
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
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

		public JsonArrayContract(Type underlyingType)
			: base(null)
		{
		}

		internal IWrappedCollection CreateWrapper(object list)
		{
			return null;
		}

		internal IList CreateTemporaryCollection()
		{
			return null;
		}

		private void StoreFSharpListCreatorIfNecessary(Type underlyingType)
		{
		}
	}
}
