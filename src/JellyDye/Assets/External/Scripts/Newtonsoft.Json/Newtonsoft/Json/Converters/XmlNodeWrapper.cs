using System.Collections.Generic;
using System.Xml;

namespace Newtonsoft.Json.Converters
{
	internal class XmlNodeWrapper : IXmlNode
	{
		private readonly XmlNode _node;

		private List<IXmlNode> _childNodes;

		private List<IXmlNode> _attributes;

		public object WrappedNode => null;

		public XmlNodeType NodeType => default(XmlNodeType);

		public virtual string LocalName => null;

		public List<IXmlNode> ChildNodes => null;

		public List<IXmlNode> Attributes => null;

		private bool HasAttributes => false;

		public IXmlNode ParentNode => null;

		public string Value
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string NamespaceUri => null;

		public XmlNodeWrapper(XmlNode node)
		{
		}

		internal static IXmlNode WrapNode(XmlNode node)
		{
			return null;
		}

		public IXmlNode AppendChild(IXmlNode newChild)
		{
			return null;
		}
	}
}
