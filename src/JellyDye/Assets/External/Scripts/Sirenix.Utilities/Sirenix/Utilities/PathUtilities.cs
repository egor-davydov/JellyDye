using System.IO;

namespace Sirenix.Utilities
{
	public static class PathUtilities
	{
		public static string GetDirectoryName(string x)
		{
			return null;
		}

		public static bool HasSubDirectory(this DirectoryInfo parentDir, DirectoryInfo subDir)
		{
			return false;
		}

		public static DirectoryInfo FindParentDirectoryWithName(this DirectoryInfo dir, string folderName)
		{
			return null;
		}

		public static bool CanMakeRelative(string absoluteParentPath, string absolutePath)
		{
			return false;
		}

		public static string MakeRelative(string absoluteParentPath, string absolutePath)
		{
			return null;
		}

		public static bool TryMakeRelative(string absoluteParentPath, string absolutePath, out string relativePath)
		{
			relativePath = null;
			return false;
		}

		public static string Combine(string a, string b)
		{
			return null;
		}
	}
}
