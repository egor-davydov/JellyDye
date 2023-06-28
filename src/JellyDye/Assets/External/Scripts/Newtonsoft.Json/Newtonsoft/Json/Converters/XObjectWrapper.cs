using System.Collections.Generic;
using System.Xml;
using System.Xml.Linq;

namespace Newtonsoft.Json.Converters
{
	internal class XObjectWrapper : IXmlNode
	{
		private readonly XObject _xmlObject;

		public object WrappedNode => null;

		public virtual XmlNodeType NodeType => default(XmlNodeType);

		public virtual string LocalName => null;

		public virtual List<IXmlNode> ChildNodes => null;

		public virtual List<IXmlNode> Attributes => null;

		public virtual IXmlNode ParentNode => null;

		public virtual string Value => null;

		public virtual string NamespaceUri => null;

		public XObjectWrapper(XObject xmlObject)
		{
		}

		public virtual IXmlNode AppendChild(IXmlNode newChild)
		{
			return null;
		}
	}
}
