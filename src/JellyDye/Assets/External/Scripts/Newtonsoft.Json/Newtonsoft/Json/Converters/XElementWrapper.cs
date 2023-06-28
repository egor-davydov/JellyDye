using System.Collections.Generic;
using System.Xml.Linq;

namespace Newtonsoft.Json.Converters
{
	internal class XElementWrapper : XContainerWrapper, IXmlElement, IXmlNode
	{
		private List<IXmlNode> _attributes;

		private XElement Element => null;

		public override List<IXmlNode> Attributes => null;

		public override string Value => null;

		public override string LocalName => null;

		public override string NamespaceUri => null;

		public bool IsEmpty => false;

		public XElementWrapper(XElement element)
			: base(null)
		{
		}

		public void SetAttributeNode(IXmlNode attribute)
		{
		}

		private bool HasImplicitNamespaceAttribute(string namespaceUri)
		{
			return false;
		}

		public override IXmlNode AppendChild(IXmlNode newChild)
		{
			return null;
		}

		public string GetPrefixOfNamespace(string namespaceUri)
		{
			return null;
		}
	}
}
