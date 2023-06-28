namespace Sirenix.OdinInspector
{
	public class BoxGroupAttribute : PropertyGroupAttribute
	{
		public bool ShowLabel;

		public bool CenterLabel;

		public BoxGroupAttribute(string group, bool showLabel = true, bool centerLabel = false, int order = 0)
			: base(null, 0)
		{
		}

		public BoxGroupAttribute()
			: base(null, 0)
		{
		}

		protected override void CombineValuesWith(PropertyGroupAttribute other)
		{
		}
	}
}
