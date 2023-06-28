using System;
using System.Collections.Generic;
using UnityEngine;

namespace Obi
{
	[ExecuteInEditMode]
	public class ObiColliderWorld
	{
		[NonSerialized]
		public List<IColliderWorldImpl> implementations;

		[NonSerialized]
		public List<ObiColliderHandle> colliderHandles;

		[NonSerialized]
		public ObiNativeColliderShapeList colliderShapes;

		[NonSerialized]
		public ObiNativeAabbList colliderAabbs;

		[NonSerialized]
		public ObiNativeAffineTransformList colliderTransforms;

		[NonSerialized]
		public List<ObiCollisionMaterialHandle> materialHandles;

		[NonSerialized]
		public ObiNativeCollisionMaterialList collisionMaterials;

		[NonSerialized]
		public List<ObiRigidbodyHandle> rigidbodyHandles;

		[NonSerialized]
		public ObiNativeRigidbodyList rigidbodies;

		[NonSerialized]
		public ObiTriangleMeshContainer triangleMeshContainer;

		[NonSerialized]
		public ObiEdgeMeshContainer edgeMeshContainer;

		[NonSerialized]
		public ObiDistanceFieldContainer distanceFieldContainer;

		[NonSerialized]
		public ObiHeightFieldContainer heightFieldContainer;

		private static ObiColliderWorld instance;

		public static ObiColliderWorld GetInstance()
		{
			return null;
		}

		private void Initialize()
		{
		}

		private void Destroy()
		{
		}

		private void DestroyIfUnused()
		{
		}

		public void RegisterImplementation(IColliderWorldImpl impl)
		{
		}

		public void UnregisterImplementation(IColliderWorldImpl impl)
		{
		}

		public ObiColliderHandle CreateCollider()
		{
			return null;
		}

		public ObiRigidbodyHandle CreateRigidbody()
		{
			return null;
		}

		public ObiCollisionMaterialHandle CreateCollisionMaterial()
		{
			return null;
		}

		public ObiTriangleMeshHandle GetOrCreateTriangleMesh(Mesh mesh)
		{
			return null;
		}

		public void DestroyTriangleMesh(ObiTriangleMeshHandle meshHandle)
		{
		}

		public ObiEdgeMeshHandle GetOrCreateEdgeMesh(EdgeCollider2D collider)
		{
			return null;
		}

		public void DestroyEdgeMesh(ObiEdgeMeshHandle meshHandle)
		{
		}

		public ObiDistanceFieldHandle GetOrCreateDistanceField(ObiDistanceField df)
		{
			return null;
		}

		public void DestroyDistanceField(ObiDistanceFieldHandle dfHandle)
		{
		}

		public ObiHeightFieldHandle GetOrCreateHeightField(TerrainData hf)
		{
			return null;
		}

		public void DestroyHeightField(ObiHeightFieldHandle hfHandle)
		{
		}

		public void DestroyCollider(ObiColliderHandle handle)
		{
		}

		public void DestroyRigidbody(ObiRigidbodyHandle handle)
		{
		}

		public void DestroyCollisionMaterial(ObiCollisionMaterialHandle handle)
		{
		}

		public void UpdateWorld()
		{
		}

		public void UpdateRigidbodies(List<ObiSolver> solvers, float stepTime)
		{
		}

		public void UpdateRigidbodyVelocities(List<ObiSolver> solvers)
		{
		}
	}
}
