using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Coffee.UIExtensions
{
	public class MaterialCache
	{
		public static List<MaterialCache> materialCaches;

		public ulong hash
		{
			[CompilerGenerated]
			get
			{
				return 0uL;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int referenceCount
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public Texture texture
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

		public Material material
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

		public static MaterialCache Register(ulong hash, Texture texture, Func<Material> onCreateMaterial)
		{
			return null;
		}

		public static MaterialCache Register(ulong hash, Func<Material> onCreateMaterial)
		{
			return null;
		}

		public static void Unregister(MaterialCache cache)
		{
		}
	}
}
