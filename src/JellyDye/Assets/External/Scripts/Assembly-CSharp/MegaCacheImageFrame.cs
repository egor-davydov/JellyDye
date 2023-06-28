using System;
using UnityEngine;

[Serializable]
public class MegaCacheImageFrame
{
	public int vc;

	public int nc;

	public int tc;

	public int uvc;

	public Vector3 bmin;

	public Vector3 uvmin;

	public Vector3 bsize;

	public Vector3 uvsize;

	public byte[] verts;

	public byte[] norms;

	public byte[] tangents;

	public byte[] uvs;

	public byte[] tris;

	public int subcount;

	public int[] suboffs;

	public int[] sublen;

	public MegaCacheImageFace[] subs;

	public void LoadSection(MegaCacheOBJ cache)
	{
	}

	public void SetMesh(Mesh mesh, MegaCacheOBJ cache)
	{
	}

	public void GetMesh(Mesh mesh, MegaCacheOBJ cache)
	{
	}
}
