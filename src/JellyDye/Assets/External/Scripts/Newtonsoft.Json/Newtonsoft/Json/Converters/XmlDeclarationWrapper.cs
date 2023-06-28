using System.Xml;

namespace Newtonsoft.Json.Converters
{
	internal class XmlDeclarationWrapper : XmlNodeWrapper, IXmlDeclaration, IXmlNode
	{
		private readonly XmlDeclaration _declaration;

		public string Version => null;

		public string Encoding => null;

		public string Standalone => null;

		public XmlDeclarationWrapper(XmlDeclaration declaration)
			: base(null)
		{
		}
	}
}
