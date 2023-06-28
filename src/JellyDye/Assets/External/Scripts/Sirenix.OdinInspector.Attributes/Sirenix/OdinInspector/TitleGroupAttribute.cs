namespace Sirenix.OdinInspector
{
	public sealed class TitleGroupAttribute : PropertyGroupAttribute
	{
		public string Subtitle;

		public TitleAlignments Alignment;

		public bool HorizontalLine;

		public bool BoldTitle;

		public bool Indent;

		public TitleGroupAttribute(string title, string subtitle = null, TitleAlignments alignment = TitleAlignments.Left, bool horizontalLine = true, bool boldTitle = true, bool indent = false, int order = 0)
			: base(null, 0)
		{
		}

		protected override void CombineValuesWith(PropertyGroupAttribute other)
		{
		}
	}
}
