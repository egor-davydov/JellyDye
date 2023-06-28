using System;

namespace Sirenix.OdinInspector
{
	public sealed class SuffixLabelAttribute : Attribute
	{
		public string Label;

		public bool Overlay;

		public SuffixLabelAttribute(string label, bool overlay = false)
		{
		}
	}
}
