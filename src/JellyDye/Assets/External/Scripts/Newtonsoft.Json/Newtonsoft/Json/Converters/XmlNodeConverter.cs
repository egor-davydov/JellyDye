using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml;

namespace Newtonsoft.Json.Converters
{
	public class XmlNodeConverter : JsonConverter
	{
		internal static readonly List<IXmlNode> EmptyChildNodes;

		private const string TextName = "#text";

		private const string CommentName = "#comment";

		private const string CDataName = "#cdata-section";

		private const string WhitespaceName = "#whitespace";

		private const string SignificantWhitespaceName = "#significant-whitespace";

		private const string DeclarationName = "?xml";

		private const string JsonNamespaceUri = "http://james.newtonking.com/projects/json";

		public string DeserializeRootElementName
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

		public bool WriteArrayAttribute
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

		public bool OmitRootObject
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

		public bool EncodeSpecialCharacters
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

		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
		}

		private IXmlNode WrapXml(object value)
		{
			return null;
		}

		private void PushParentNamespaces(IXmlNode node, XmlNamespaceManager manager)
		{
		}

		private string ResolveFullName(IXmlNode node, XmlNamespaceManager manager)
		{
			return null;
		}

		private string GetPropertyName(IXmlNode node, XmlNamespaceManager manager)
		{
			return null;
		}

		private bool IsArray(IXmlNode node)
		{
			return false;
		}

		private void SerializeGroupedNodes(JsonWriter writer, IXmlNode node, XmlNamespaceManager manager, bool writePropertyName)
		{
		}

		private void WriteGroupedNodes(JsonWriter writer, XmlNamespaceManager manager, bool writePropertyName, List<IXmlNode> groupedNodes, string elementNames)
		{
		}

		private void WriteGroupedNodes(JsonWriter writer, XmlNamespaceManager manager, bool writePropertyName, IXmlNode node, string elementNames)
		{
		}

		private void SerializeNode(JsonWriter writer, IXmlNode node, XmlNamespaceManager manager, bool writePropertyName)
		{
		}

		private static bool AllSameName(IXmlNode node)
		{
			return false;
		}

		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		private void DeserializeValue(JsonReader reader, IXmlDocument document, XmlNamespaceManager manager, string propertyName, IXmlNode currentNode)
		{
		}

		private void ReadElement(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string propertyName, XmlNamespaceManager manager)
		{
		}

		private void CreateElement(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string elementName, XmlNamespaceManager manager, string elementPrefix, Dictionary<string, string> attributeNameValues)
		{
		}

		private static void AddAttribute(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string propertyName, string attributeName, XmlNamespaceManager manager, string attributePrefix)
		{
		}

		private static string ConvertTokenToXmlValue(JsonReader reader)
		{
			return null;
		}

		private void ReadArrayElements(JsonReader reader, IXmlDocument document, string propertyName, IXmlNode currentNode, XmlNamespaceManager manager)
		{
		}

		private void AddJsonArrayAttribute(IXmlElement element, IXmlDocument document)
		{
		}

		private bool ShouldReadInto(JsonReader reader)
		{
			return false;
		}

		private Dictionary<string, string> ReadAttributeElements(JsonReader reader, XmlNamespaceManager manager)
		{
			return null;
		}

		private void CreateInstruction(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string propertyName)
		{
		}

		private void CreateDocumentType(JsonReader reader, IXmlDocument document, IXmlNode currentNode)
		{
		}

		private IXmlElement CreateElement(string elementName, IXmlDocument document, string elementPrefix, XmlNamespaceManager manager)
		{
			return null;
		}

		private void DeserializeNode(JsonReader reader, IXmlDocument document, XmlNamespaceManager manager, IXmlNode currentNode)
		{
		}

		private bool IsNamespaceAttribute(string attributeName, out string prefix)
		{
			prefix = null;
			return false;
		}

		private bool ValueAttributes(List<IXmlNode> c)
		{
			return false;
		}

		public override bool CanConvert(Type valueType)
		{
			return false;
		}

		[MethodImpl(8)]
		private bool IsXObject(Type valueType)
		{
			return false;
		}

		[MethodImpl(8)]
		private bool IsXmlNode(Type valueType)
		{
			return false;
		}
	}
}
