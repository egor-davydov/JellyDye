using System.Xml.Linq;

namespace Newtonsoft.Json.Converters
{
	internal class XProcessingInstructionWrapper : XObjectWrapper
	{
		private XProcessingInstruction ProcessingInstruction => null;

		public override string LocalName => null;

		public override string Value => null;

		public XProcessingInstructionWrapper(XProcessingInstruction processingInstruction)
			: base(null)
		{
		}
	}
}
