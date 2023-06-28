using System;
using System.Runtime.CompilerServices;

namespace Sirenix.Utilities
{
	public class GlobalConfigAttribute : Attribute
	{
		private string assetPath;

		[Obsolete]
		public string FullPath => null;

		public string AssetPath => null;

		internal string AssetPathWithAssetsPrefix => null;

		internal string AssetPathWithoutAssetsPrefix => null;

		public string ResourcesPath => null;

		public bool UseAsset
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

		public bool IsInResourcesFolder => false;

		public GlobalConfigAttribute()
		{
		}

		public GlobalConfigAttribute(string assetPath)
		{
		}
	}
}
