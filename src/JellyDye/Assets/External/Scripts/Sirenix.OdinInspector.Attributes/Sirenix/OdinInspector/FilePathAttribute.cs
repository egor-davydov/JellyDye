using System;
using System.Runtime.CompilerServices;

namespace Sirenix.OdinInspector
{
	public sealed class FilePathAttribute : Attribute
	{
		public bool AbsolutePath;

		public string Extensions;

		public string ParentFolder;

		[Obsolete]
		public bool RequireValidPath;

		public bool RequireExistingPath;

		public bool UseBackslashes;

		[Obsolete]
		public bool ReadOnly
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
