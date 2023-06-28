using System.Collections.Generic;
using UnityEngine;

namespace Obi
{
	public class ObiEdgeMeshContainer
	{
		public Dictionary<EdgeCollider2D, ObiEdgeMeshHandle> handles;

		public ObiNativeEdgeMeshHeaderList headers;

		public ObiNativeBIHNodeList bihNodes;

		public ObiNativeEdgeList edges;

		public ObiNativeVector2List vertices;

		public ObiEdgeMeshHandle GetOrCreateEdgeMesh(EdgeCollider2D source)
		{
			return null;
		}

		public void DestroyEdgeMesh(ObiEdgeMeshHandle handle)
		{
		}

		public void Dispose()
		{
		}
	}
}
