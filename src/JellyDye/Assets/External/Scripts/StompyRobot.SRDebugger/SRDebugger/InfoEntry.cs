using System;
using System.Runtime.CompilerServices;

namespace SRDebugger
{
	public sealed class InfoEntry
	{
		private Func<object> _valueGetter;

		public string Title
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public object Value => null;

		public bool IsPrivate
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

		public static InfoEntry Create(string name, Func<object> getter, bool isPrivate = false)
		{
			return null;
		}

		public static InfoEntry Create(string name, object value, bool isPrivate = false)
		{
			return null;
		}
	}
}
