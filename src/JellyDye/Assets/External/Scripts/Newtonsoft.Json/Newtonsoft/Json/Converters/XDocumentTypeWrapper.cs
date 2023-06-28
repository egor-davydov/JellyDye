using System.Xml.Linq;

namespace Newtonsoft.Json.Converters
{
	internal class XDocumentTypeWrapper : XObjectWrapper, IXmlDocumentType, IXmlNode
	{
		private readonly XDocumentType _documentType;

		public string Name => null;

		public string System => null;

		public string Public => null;

		public string InternalSubset => null;

		public override string LocalName => null;

		public XDocumentTypeWrapper(XDocumentType documentType)
			: base(null)
		{
		}
	}
}
