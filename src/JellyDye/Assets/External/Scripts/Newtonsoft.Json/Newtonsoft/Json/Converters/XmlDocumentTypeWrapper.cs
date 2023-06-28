using System.Xml;

namespace Newtonsoft.Json.Converters
{
	internal class XmlDocumentTypeWrapper : XmlNodeWrapper, IXmlDocumentType, IXmlNode
	{
		private readonly XmlDocumentType _documentType;

		public string Name => null;

		public string System => null;

		public string Public => null;

		public string InternalSubset => null;

		public override string LocalName => null;

		public XmlDocumentTypeWrapper(XmlDocumentType documentType)
			: base(null)
		{
		}
	}
}
