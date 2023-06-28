using UnityEngine;

namespace Obi
{
	public class OniColliderWorld : MonoBehaviour, IColliderWorldImpl
	{
		private int refCount;

		public int referenceCount => 0;

		public void Awake()
		{
		}

		public void OnDestroy()
		{
		}

		public void IncreaseReferenceCount()
		{
		}

		public void DecreaseReferenceCount()
		{
		}

		public void UpdateWorld()
		{
		}

		public void SetColliders(ObiNativeColliderShapeList shapes, ObiNativeAabbList bounds, ObiNativeAffineTransformList transforms, int count)
		{
		}

		public void SetRigidbodies(ObiNativeRigidbodyList rigidbody)
		{
		}

		public void SetCollisionMaterials(ObiNativeCollisionMaterialList materials)
		{
		}

		public void SetTriangleMeshData(ObiNativeTriangleMeshHeaderList headers, ObiNativeBIHNodeList nodes, ObiNativeTriangleList triangles, ObiNativeVector3List vertices)
		{
		}

		public void SetEdgeMeshData(ObiNativeEdgeMeshHeaderList headers, ObiNativeBIHNodeList nodes, ObiNativeEdgeList edges, ObiNativeVector2List vertices)
		{
		}

		public void SetDistanceFieldData(ObiNativeDistanceFieldHeaderList headers, ObiNativeDFNodeList nodes)
		{
		}

		public void SetHeightFieldData(ObiNativeHeightFieldHeaderList headers, ObiNativeFloatList samples)
		{
		}
	}
}
