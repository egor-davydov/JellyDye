using System.Collections.Generic;
using System.Xml.Linq;

namespace Newtonsoft.Json.Converters
{
	internal class XContainerWrapper : XObjectWrapper
	{
		private List<IXmlNode> _childNodes;

		private XContainer Container => null;

		public override List<IXmlNode> ChildNodes => null;

		protected virtual bool HasChildNodes => false;

		public override IXmlNode ParentNode => null;

		public XContainerWrapper(XContainer container)
			: base(null)
		{
		}

		internal static IXmlNode WrapNode(XObject node)
		{
			return null;
		}

		public override IXmlNode AppendChild(IXmlNode newChild)
		{
			return null;
		}
	}
}
