namespace Sirenix.OdinInspector
{
	public class HideIfGroupAttribute : PropertyGroupAttribute
	{
		private string memberName;

		public bool Animate;

		public object Value;

		public string MemberName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public HideIfGroupAttribute(string path, bool animate = true)
			: base(null, 0)
		{
		}

		public HideIfGroupAttribute(string path, object value, bool animate = true)
			: base(null, 0)
		{
		}

		protected override void CombineValuesWith(PropertyGroupAttribute other)
		{
		}
	}
}
