using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json.Linq;

namespace Newtonsoft.Json.Serialization
{
	internal class JsonSerializerInternalReader : JsonSerializerInternalBase
	{
		internal enum PropertyPresence
		{
			None = 0,
			Null = 1,
			Value = 2
		}

		internal class CreatorPropertyContext
		{
			public readonly string Name;

			public JsonProperty Property;

			public JsonProperty ConstructorProperty;

			public PropertyPresence? Presence;

			public object Value;

			public bool Used;

			public CreatorPropertyContext(string name)
			{
			}
		}

		public JsonSerializerInternalReader(JsonSerializer serializer)
			: base(null)
		{
		}

		public void Populate(JsonReader reader, object target)
		{
		}

		private JsonContract GetContractSafe(Type type)
		{
			return null;
		}

		private JsonContract GetContract(Type type)
		{
			return null;
		}

		public object Deserialize(JsonReader reader, Type objectType, bool checkAdditionalContent)
		{
			return null;
		}

		private JsonSerializerProxy GetInternalSerializer()
		{
			return null;
		}

		private JToken CreateJToken(JsonReader reader, JsonContract contract)
		{
			return null;
		}

		private JToken CreateJObject(JsonReader reader)
		{
			return null;
		}

		private object CreateValueInternal(JsonReader reader, Type objectType, JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, object existingValue)
		{
			return null;
		}

		private static bool CoerceEmptyStringToNull(Type objectType, JsonContract contract, string s)
		{
			return false;
		}

		internal string GetExpectedDescription(JsonContract contract)
		{
			return null;
		}

		private JsonConverter GetConverter(JsonContract contract, JsonConverter memberConverter, JsonContainerContract containerContract, JsonProperty containerProperty)
		{
			return null;
		}

		private object CreateObject(JsonReader reader, Type objectType, JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, object existingValue)
		{
			return null;
		}

		private bool ReadMetadataPropertiesToken(JTokenReader reader, ref Type objectType, ref JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, object existingValue, out object newValue, out string id)
		{
			newValue = null;
			id = null;
			return false;
		}

		private bool ReadMetadataProperties(JsonReader reader, ref Type objectType, ref JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, object existingValue, out object newValue, out string id)
		{
			newValue = null;
			id = null;
			return false;
		}

		private void ResolveTypeName(JsonReader reader, ref Type objectType, ref JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, string qualifiedTypeName)
		{
		}

		private JsonArrayContract EnsureArrayContract(JsonReader reader, Type objectType, JsonContract contract)
		{
			return null;
		}

		private object CreateList(JsonReader reader, Type objectType, JsonContract contract, JsonProperty member, object existingValue, string id)
		{
			return null;
		}

		private bool HasNoDefinedType(JsonContract contract)
		{
			return false;
		}

		private object EnsureType(JsonReader reader, object value, CultureInfo culture, JsonContract contract, Type targetType)
		{
			return null;
		}

		private bool SetPropertyValue(JsonProperty property, JsonConverter propertyConverter, JsonContainerContract containerContract, JsonProperty containerProperty, JsonReader reader, object target)
		{
			return false;
		}

		private bool CalculatePropertyDetails(JsonProperty property, ref JsonConverter propertyConverter, JsonContainerContract containerContract, JsonProperty containerProperty, JsonReader reader, object target, out bool useExistingValue, out object currentValue, out JsonContract propertyContract, out bool gottenCurrentValue, out bool ignoredValue)
		{
			useExistingValue = default(bool);
			currentValue = null;
			propertyContract = null;
			gottenCurrentValue = default(bool);
			ignoredValue = default(bool);
			return false;
		}

		private void AddReference(JsonReader reader, string id, object value)
		{
		}

		private bool HasFlag(DefaultValueHandling value, DefaultValueHandling flag)
		{
			return false;
		}

		private bool ShouldSetPropertyValue(JsonProperty property, JsonObjectContract contract, object value)
		{
			return false;
		}

		private IList CreateNewList(JsonReader reader, JsonArrayContract contract, out bool createdFromNonDefaultCreator)
		{
			createdFromNonDefaultCreator = default(bool);
			return null;
		}

		private IDictionary CreateNewDictionary(JsonReader reader, JsonDictionaryContract contract, out bool createdFromNonDefaultCreator)
		{
			createdFromNonDefaultCreator = default(bool);
			return null;
		}

		private void OnDeserializing(JsonReader reader, JsonContract contract, object value)
		{
		}

		private void OnDeserialized(JsonReader reader, JsonContract contract, object value)
		{
		}

		private object PopulateDictionary(IDictionary dictionary, JsonReader reader, JsonDictionaryContract contract, JsonProperty containerProperty, string id)
		{
			return null;
		}

		private object PopulateMultidimensionalArray(IList list, JsonReader reader, JsonArrayContract contract, JsonProperty containerProperty, string id)
		{
			return null;
		}

		private void ThrowUnexpectedEndException(JsonReader reader, JsonContract contract, object currentObject, string message)
		{
		}

		private object PopulateList(IList list, JsonReader reader, JsonArrayContract contract, JsonProperty containerProperty, string id)
		{
			return null;
		}

		private object CreateISerializable(JsonReader reader, JsonISerializableContract contract, JsonProperty member, string id)
		{
			return null;
		}

		internal object CreateISerializableItem(JToken token, Type type, JsonISerializableContract contract, JsonProperty member)
		{
			return null;
		}

		private object CreateDynamic(JsonReader reader, JsonDynamicContract contract, JsonProperty member, string id)
		{
			return null;
		}

		private object CreateObjectUsingCreatorWithParameters(JsonReader reader, JsonObjectContract contract, JsonProperty containerProperty, ObjectConstructor<object> creator, string id)
		{
			return null;
		}

		private object DeserializeConvertable(JsonConverter converter, JsonReader reader, Type objectType, object existingValue)
		{
			return null;
		}

		private List<CreatorPropertyContext> ResolvePropertyAndCreatorValues(JsonObjectContract contract, JsonProperty containerProperty, JsonReader reader, Type objectType)
		{
			return null;
		}

		public object CreateNewObject(JsonReader reader, JsonObjectContract objectContract, JsonProperty containerMember, JsonProperty containerProperty, string id, out bool createdFromNonDefaultCreator)
		{
			createdFromNonDefaultCreator = default(bool);
			return null;
		}

		private object PopulateObject(object newObject, JsonReader reader, JsonObjectContract contract, JsonProperty member, string id)
		{
			return null;
		}

		private bool ShouldDeserialize(JsonReader reader, JsonProperty property, object target)
		{
			return false;
		}

		private bool CheckPropertyName(JsonReader reader, string memberName)
		{
			return false;
		}

		private void SetExtensionData(JsonObjectContract contract, JsonProperty member, JsonReader reader, string memberName, object o)
		{
		}

		private object ReadExtensionDataValue(JsonObjectContract contract, JsonProperty member, JsonReader reader)
		{
			return null;
		}

		private void EndProcessProperty(object newObject, JsonReader reader, JsonObjectContract contract, int initialDepth, JsonProperty property, PropertyPresence presence, bool setDefaultValue)
		{
		}

		private void SetPropertyPresence(JsonReader reader, JsonProperty property, Dictionary<JsonProperty, PropertyPresence> requiredProperties)
		{
		}

		private void HandleError(JsonReader reader, bool readPastError, int initialDepth)
		{
		}
	}
}
