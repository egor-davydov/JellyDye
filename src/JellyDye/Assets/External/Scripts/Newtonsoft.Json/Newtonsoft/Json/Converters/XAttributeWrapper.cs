using System.Xml.Linq;

namespace Newtonsoft.Json.Converters
{
	internal class XAttributeWrapper : XObjectWrapper
	{
		private XAttribute Attribute => null;

		public override string Value => null;

		public override string LocalName => null;

		public override string NamespaceUri => null;

		public override IXmlNode ParentNode => null;

		public XAttributeWrapper(XAttribute attribute)
			: base(null)
		{
		}
	}
}
