using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Runtime.Serialization;

namespace Newtonsoft.Json.Serialization
{
	internal class JsonSerializerInternalWriter : JsonSerializerInternalBase
	{
		private Type _rootType;

		private int _rootLevel;

		private readonly List<object> _serializeStack;

		public JsonSerializerInternalWriter(JsonSerializer serializer)
			: base(null)
		{
		}

		public void Serialize(JsonWriter jsonWriter, object value, Type objectType)
		{
		}

		private JsonSerializerProxy GetInternalSerializer()
		{
			return null;
		}

		private JsonContract GetContractSafe(object value)
		{
			return null;
		}

		private JsonContract GetContract(object value)
		{
			return null;
		}

		private void SerializePrimitive(JsonWriter writer, object value, JsonPrimitiveContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerProperty)
		{
		}

		private void SerializeValue(JsonWriter writer, object value, JsonContract valueContract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerProperty)
		{
		}

		private bool? ResolveIsReference(JsonContract contract, JsonProperty property, JsonContainerContract collectionContract, JsonProperty containerProperty)
		{
			return null;
		}

		private bool ShouldWriteReference(object value, JsonProperty property, JsonContract valueContract, JsonContainerContract collectionContract, JsonProperty containerProperty)
		{
			return false;
		}

		private bool ShouldWriteProperty(object memberValue, JsonObjectContract containerContract, JsonProperty property)
		{
			return false;
		}

		private bool CheckForCircularReference(JsonWriter writer, object value, JsonProperty property, JsonContract contract, JsonContainerContract containerContract, JsonProperty containerProperty)
		{
			return false;
		}

		private void WriteReference(JsonWriter writer, object value)
		{
		}

		private string GetReference(JsonWriter writer, object value)
		{
			return null;
		}

		internal static bool TryConvertToString(object value, Type type, out string s)
		{
			s = null;
			return false;
		}

		private void SerializeString(JsonWriter writer, object value, JsonStringContract contract)
		{
		}

		private void OnSerializing(JsonWriter writer, JsonContract contract, object value)
		{
		}

		private void OnSerialized(JsonWriter writer, JsonContract contract, object value)
		{
		}

		private void SerializeObject(JsonWriter writer, object value, JsonObjectContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty)
		{
		}

		private bool CalculatePropertyValues(JsonWriter writer, object value, JsonContainerContract contract, JsonProperty member, JsonProperty property, out JsonContract memberContract, out object memberValue)
		{
			memberContract = null;
			memberValue = null;
			return false;
		}

		private void WriteObjectStart(JsonWriter writer, object value, JsonContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty)
		{
		}

		private bool HasCreatorParameter(JsonContainerContract contract, JsonProperty property)
		{
			return false;
		}

		private void WriteReferenceIdProperty(JsonWriter writer, Type type, object value)
		{
		}

		private void WriteTypeProperty(JsonWriter writer, Type type)
		{
		}

		private bool HasFlag(DefaultValueHandling value, DefaultValueHandling flag)
		{
			return false;
		}

		private bool HasFlag(PreserveReferencesHandling value, PreserveReferencesHandling flag)
		{
			return false;
		}

		private bool HasFlag(TypeNameHandling value, TypeNameHandling flag)
		{
			return false;
		}

		private void SerializeConvertable(JsonWriter writer, JsonConverter converter, object value, JsonContract contract, JsonContainerContract collectionContract, JsonProperty containerProperty)
		{
		}

		private void SerializeList(JsonWriter writer, IEnumerable values, JsonArrayContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty)
		{
		}

		private void SerializeMultidimensionalArray(JsonWriter writer, Array values, JsonArrayContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty)
		{
		}

		private void SerializeMultidimensionalArray(JsonWriter writer, Array values, JsonArrayContract contract, JsonProperty member, int initialDepth, int[] indices)
		{
		}

		private bool WriteStartArray(JsonWriter writer, object values, JsonArrayContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerProperty)
		{
			return false;
		}

		private void SerializeISerializable(JsonWriter writer, ISerializable value, JsonISerializableContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty)
		{
		}

		private void SerializeDynamic(JsonWriter writer, IDynamicMetaObjectProvider value, JsonDynamicContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty)
		{
		}

		private bool ShouldWriteDynamicProperty(object memberValue)
		{
			return false;
		}

		private bool ShouldWriteType(TypeNameHandling typeNameHandlingFlag, JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerProperty)
		{
			return false;
		}

		private void SerializeDictionary(JsonWriter writer, IDictionary values, JsonDictionaryContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty)
		{
		}

		private string GetPropertyName(JsonWriter writer, object name, JsonContract contract, out bool escape)
		{
			escape = default(bool);
			return null;
		}

		private void HandleError(JsonWriter writer, int initialDepth)
		{
		}

		private bool ShouldSerialize(JsonWriter writer, JsonProperty property, object target)
		{
			return false;
		}

		private bool IsSpecified(JsonWriter writer, JsonProperty property, object target)
		{
			return false;
		}
	}
}
