using System.Xml.Linq;

namespace Newtonsoft.Json.Converters
{
	internal class XCommentWrapper : XObjectWrapper
	{
		private XComment Text => null;

		public override string Value => null;

		public override IXmlNode ParentNode => null;

		public XCommentWrapper(XComment text)
			: base(null)
		{
		}
	}
}
