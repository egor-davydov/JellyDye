namespace Sirenix.OdinInspector
{
	public class ShowIfGroupAttribute : PropertyGroupAttribute
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

		public ShowIfGroupAttribute(string path, bool animate = true)
			: base(null, 0)
		{
		}

		public ShowIfGroupAttribute(string path, object value, bool animate = true)
			: base(null, 0)
		{
		}

		protected override void CombineValuesWith(PropertyGroupAttribute other)
		{
		}
	}
}
