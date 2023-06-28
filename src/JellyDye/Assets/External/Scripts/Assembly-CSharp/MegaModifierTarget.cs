using System;
using UnityEngine;

[Serializable]
public class MegaModifierTarget
{
	public Vector3[] verts;

	public Vector3[] sverts;

	public Vector2[] uvs;

	public Vector2[] suvs;

	public Mesh mesh;

	public Mesh cachedMesh;

	public Vector4[] tangents;

	public Vector3[] tan1;

	public Vector3[] tan2;

	public MeshCollider meshCol;

	public GameObject go;

	public MegaBox3 bbox;

	public Vector3 Offset;
}
