using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	public class DefaultContractResolver : IContractResolver
	{
		internal class EnumerableDictionaryWrapper<TEnumeratorKey, TEnumeratorValue> : IEnumerable<KeyValuePair<object, object>>, IEnumerable
		{
			private readonly IEnumerable<KeyValuePair<TEnumeratorKey, TEnumeratorValue>> _e;

			public EnumerableDictionaryWrapper(IEnumerable<KeyValuePair<TEnumeratorKey, TEnumeratorValue>> e)
			{
			}

			public IEnumerator<KeyValuePair<object, object>> GetEnumerator()
			{
				return null;
			}

			private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
			{
				return null;
			}
		}

		private static readonly IContractResolver _instance;

		private static readonly string[] BlacklistedTypeNames;

		private static readonly JsonConverter[] BuiltInConverters;

		private readonly DefaultJsonNameTable _nameTable;

		private readonly ThreadSafeStore<Type, JsonContract> _contractCache;

		internal static IContractResolver Instance => null;

		[Obsolete]
		public BindingFlags DefaultMembersSearchFlags
		{
			[CompilerGenerated]
			get
			{
				return default(BindingFlags);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool SerializeCompilerGeneratedMembers
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
		}

		public bool IgnoreSerializableInterface
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
		}

		public bool IgnoreSerializableAttribute
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

		public bool IgnoreIsSpecifiedMembers
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
		}

		public bool IgnoreShouldSerializeMembers
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
		}

		public NamingStrategy NamingStrategy
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public virtual JsonContract ResolveContract(Type type)
		{
			return null;
		}

		private static bool FilterMembers(MemberInfo member)
		{
			return false;
		}

		protected virtual List<MemberInfo> GetSerializableMembers(Type objectType)
		{
			return null;
		}

		private bool ShouldSerializeEntityMember(MemberInfo memberInfo)
		{
			return false;
		}

		protected virtual JsonObjectContract CreateObjectContract(Type objectType)
		{
			return null;
		}

		private static void ThrowUnableToSerializeError(object o, StreamingContext context)
		{
		}

		private MemberInfo GetExtensionDataMemberForType(Type type)
		{
			return null;
		}

		private static void SetExtensionDataDelegates(JsonObjectContract contract, MemberInfo member)
		{
		}

		private ConstructorInfo GetAttributeConstructor(Type objectType)
		{
			return null;
		}

		private ConstructorInfo GetImmutableConstructor(Type objectType, JsonPropertyCollection memberProperties)
		{
			return null;
		}

		private ConstructorInfo GetParameterizedConstructor(Type objectType)
		{
			return null;
		}

		protected virtual IList<JsonProperty> CreateConstructorParameters(ConstructorInfo constructor, JsonPropertyCollection memberProperties)
		{
			return null;
		}

		private JsonProperty MatchProperty(JsonPropertyCollection properties, string name, Type type)
		{
			return null;
		}

		protected virtual JsonProperty CreatePropertyFromConstructorParameter(JsonProperty matchingMemberProperty, ParameterInfo parameterInfo)
		{
			return null;
		}

		protected virtual JsonConverter ResolveContractConverter(Type objectType)
		{
			return null;
		}

		private Func<object> GetDefaultCreator(Type createdType)
		{
			return null;
		}

		private void InitializeContract(JsonContract contract)
		{
		}

		private void ResolveCallbackMethods(JsonContract contract, Type t)
		{
		}

		private void GetCallbackMethodsForType(Type type, out List<SerializationCallback> onSerializing, out List<SerializationCallback> onSerialized, out List<SerializationCallback> onDeserializing, out List<SerializationCallback> onDeserialized, out List<SerializationErrorCallback> onError)
		{
			onSerializing = null;
			onSerialized = null;
			onDeserializing = null;
			onDeserialized = null;
			onError = null;
		}

		private static bool IsConcurrentOrObservableCollection(Type t)
		{
			return false;
		}

		private static bool ShouldSkipDeserialized(Type t)
		{
			return false;
		}

		private static bool ShouldSkipSerializing(Type t)
		{
			return false;
		}

		private List<Type> GetClassHierarchyForType(Type type)
		{
			return null;
		}

		protected virtual JsonDictionaryContract CreateDictionaryContract(Type objectType)
		{
			return null;
		}

		protected virtual JsonArrayContract CreateArrayContract(Type objectType)
		{
			return null;
		}

		protected virtual JsonPrimitiveContract CreatePrimitiveContract(Type objectType)
		{
			return null;
		}

		protected virtual JsonLinqContract CreateLinqContract(Type objectType)
		{
			return null;
		}

		protected virtual JsonISerializableContract CreateISerializableContract(Type objectType)
		{
			return null;
		}

		protected virtual JsonDynamicContract CreateDynamicContract(Type objectType)
		{
			return null;
		}

		protected virtual JsonStringContract CreateStringContract(Type objectType)
		{
			return null;
		}

		protected virtual JsonContract CreateContract(Type objectType)
		{
			return null;
		}

		internal static bool IsJsonPrimitiveType(Type t)
		{
			return false;
		}

		internal static bool IsIConvertible(Type t)
		{
			return false;
		}

		internal static bool CanConvertToString(Type type)
		{
			return false;
		}

		private static bool IsValidCallback(MethodInfo method, ParameterInfo[] parameters, Type attributeType, MethodInfo currentCallback, ref Type prevAttributeType)
		{
			return false;
		}

		internal static string GetClrTypeFullName(Type type)
		{
			return null;
		}

		protected virtual IList<JsonProperty> CreateProperties(Type type, MemberSerialization memberSerialization)
		{
			return null;
		}

		internal virtual DefaultJsonNameTable GetNameTable()
		{
			return null;
		}

		protected virtual IValueProvider CreateMemberValueProvider(MemberInfo member)
		{
			return null;
		}

		protected virtual JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization)
		{
			return null;
		}

		private void SetPropertySettingsFromAttributes(JsonProperty property, object attributeProvider, string name, Type declaringType, MemberSerialization memberSerialization, out bool allowNonPublicAccess)
		{
			allowNonPublicAccess = default(bool);
		}

		private Predicate<object> CreateShouldSerializeTest(MemberInfo member)
		{
			return null;
		}

		private void SetIsSpecifiedActions(JsonProperty property, MemberInfo member, bool allowNonPublicAccess)
		{
		}

		protected virtual string ResolvePropertyName(string propertyName)
		{
			return null;
		}

		protected virtual string ResolveExtensionDataName(string extensionDataName)
		{
			return null;
		}

		protected virtual string ResolveDictionaryKey(string dictionaryKey)
		{
			return null;
		}

		public string GetResolvedPropertyName(string propertyName)
		{
			return null;
		}
	}
}
