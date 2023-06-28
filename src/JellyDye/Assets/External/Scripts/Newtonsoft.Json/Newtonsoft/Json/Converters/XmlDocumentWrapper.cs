using System.Xml;

namespace Newtonsoft.Json.Converters
{
	internal class XmlDocumentWrapper : XmlNodeWrapper, IXmlDocument, IXmlNode
	{
		private readonly XmlDocument _document;

		public IXmlElement DocumentElement => null;

		public XmlDocumentWrapper(XmlDocument document)
			: base(null)
		{
		}

		public IXmlNode CreateComment(string data)
		{
			return null;
		}

		public IXmlNode CreateTextNode(string text)
		{
			return null;
		}

		public IXmlNode CreateCDataSection(string data)
		{
			return null;
		}

		public IXmlNode CreateWhitespace(string text)
		{
			return null;
		}

		public IXmlNode CreateSignificantWhitespace(string text)
		{
			return null;
		}

		public IXmlNode CreateXmlDeclaration(string version, string encoding, string standalone)
		{
			return null;
		}

		public IXmlNode CreateXmlDocumentType(string name, string publicId, string systemId, string internalSubset)
		{
			return null;
		}

		public IXmlNode CreateProcessingInstruction(string target, string data)
		{
			return null;
		}

		public IXmlElement CreateElement(string elementName)
		{
			return null;
		}

		public IXmlElement CreateElement(string qualifiedName, string namespaceUri)
		{
			return null;
		}

		public IXmlNode CreateAttribute(string name, string value)
		{
			return null;
		}

		public IXmlNode CreateAttribute(string qualifiedName, string namespaceUri, string value)
		{
			return null;
		}
	}
}
