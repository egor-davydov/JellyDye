using System.Xml;

namespace Newtonsoft.Json.Converters
{
	internal class XmlElementWrapper : XmlNodeWrapper, IXmlElement, IXmlNode
	{
		private readonly XmlElement _element;

		public bool IsEmpty => false;

		public XmlElementWrapper(XmlElement element)
			: base(null)
		{
		}

		public void SetAttributeNode(IXmlNode attribute)
		{
		}

		public string GetPrefixOfNamespace(string namespaceUri)
		{
			return null;
		}
	}
}
