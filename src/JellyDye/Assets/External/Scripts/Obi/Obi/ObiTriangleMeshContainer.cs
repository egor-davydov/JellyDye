using System.Collections.Generic;
using UnityEngine;

namespace Obi
{
	public class ObiTriangleMeshContainer
	{
		public Dictionary<Mesh, ObiTriangleMeshHandle> handles;

		public ObiNativeTriangleMeshHeaderList headers;

		public ObiNativeBIHNodeList bihNodes;

		public ObiNativeTriangleList triangles;

		public ObiNativeVector3List vertices;

		public ObiTriangleMeshHandle GetOrCreateTriangleMesh(Mesh source)
		{
			return null;
		}

		public void DestroyTriangleMesh(ObiTriangleMeshHandle handle)
		{
		}

		public void Dispose()
		{
		}
	}
}
