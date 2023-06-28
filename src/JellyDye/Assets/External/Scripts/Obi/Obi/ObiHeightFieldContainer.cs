using System.Collections.Generic;
using UnityEngine;

namespace Obi
{
	public class ObiHeightFieldContainer
	{
		public Dictionary<TerrainData, ObiHeightFieldHandle> handles;

		public ObiNativeHeightFieldHeaderList headers;

		public ObiNativeFloatList samples;

		public ObiHeightFieldHandle GetOrCreateHeightField(TerrainData source)
		{
			return null;
		}

		public void DestroyHeightField(ObiHeightFieldHandle handle)
		{
		}

		public void Dispose()
		{
		}
	}
}
