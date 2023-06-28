using System;
using UnityEngine;

[ExecuteInEditMode]
public class MegaAttach : MonoBehaviour
{
	[Serializable]
	public class MegaSkinVert
	{
		public float[] weights;

		public Transform[] bones;

		public Matrix4x4[] bindposes;

		public int vert;
	}

	public MegaModifiers target;

	[HideInInspector]
	public Vector3 BaryCoord;

	[HideInInspector]
	public int[] BaryVerts;

	[HideInInspector]
	public bool attached;

	[HideInInspector]
	public Vector3 BaryCoord1;

	[HideInInspector]
	public int[] BaryVerts1;

	public Vector3 attachforward;

	public Vector3 AxisRot;

	public float radius;

	public Vector3 up;

	public bool worldSpace;

	private Vector3 pt;

	private Vector3 norm;

	public bool skinned;

	public MegaSkinVert[] skinverts;

	public Quaternion attachrot;

	private Vector3[] calcskinverts;

	public void Help()
	{
	}

	public void DetachIt()
	{
	}

	public void AttachIt()
	{
	}

	public void AttachIt(Vector3 pos)
	{
	}

	private void OnDrawGizmosSelected()
	{
	}

	private void LateUpdate()
	{
	}

	private Vector3 GetCoordMine(Vector3 A, Vector3 B, Vector3 C, Vector3 bary)
	{
		return default(Vector3);
	}

	private bool InitSkin()
	{
		return false;
	}

	private Vector3 GetSkinPos(int i)
	{
		return default(Vector3);
	}

	private void CalcSkinVerts()
	{
	}

	private void GetSkinPos1()
	{
	}
}
