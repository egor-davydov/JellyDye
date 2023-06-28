using System;

namespace Sirenix.OdinInspector
{
	public sealed class FolderPathAttribute : Attribute
	{
		public bool AbsolutePath;

		public string ParentFolder;

		[Obsolete]
		public bool RequireValidPath;

		public bool RequireExistingPath;

		public bool UseBackslashes;
	}
}
