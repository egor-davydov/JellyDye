using System.Reflection;
using System.Runtime.CompilerServices;

namespace Obi
{
	public class VisibleIf : MultiPropertyAttribute
	{
		private MethodInfo eventMethodInfo;

		private FieldInfo fieldInfo;

		public string MethodName
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool Negate
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public VisibleIf(string methodName, bool negate = false)
		{
		}
	}
}
