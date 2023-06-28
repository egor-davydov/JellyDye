using System.Runtime.CompilerServices;
using System.Xml;
using System.Xml.Linq;

namespace Newtonsoft.Json.Converters
{
	internal class XDeclarationWrapper : XObjectWrapper, IXmlDeclaration, IXmlNode
	{
		internal XDeclaration Declaration
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public override XmlNodeType NodeType => default(XmlNodeType);

		public string Version => null;

		public string Encoding => null;

		public string Standalone => null;

		public XDeclarationWrapper(XDeclaration declaration)
			: base(null)
		{
		}
	}
}
