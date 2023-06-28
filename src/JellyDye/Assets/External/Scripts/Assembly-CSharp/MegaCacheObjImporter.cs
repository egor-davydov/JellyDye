using System.Collections.Generic;
using UnityEngine;

public class MegaCacheObjImporter
{
	private class MegaCacheOBJFace
	{
		public int[] v;

		public int[] uv;

		public int[] n;

		public bool quad;

		public int smthgrp;

		public int mtl;
	}

	private class MegaCacheOBJMesh
	{
		public List<Vector3> vertices;

		public List<Vector3> normals;

		public List<Vector2> uv;

		public List<Vector2> uv1;

		public List<Vector2> uv2;

		public List<MegaCacheOBJFace> faces;
	}

	private static List<MegaCacheOBJMtl> mtls;

	private static List<MegaCacheFace> faces;

	private static int currentmtl;

	private static int smthgrp;

	private static int offset;

	private static int offsetmtl;

	private static MegaCacheOBJMtl loadmtl;

	private static string importpath;

	public static void Init()
	{
	}

	public static int NumMtls()
	{
		return 0;
	}

	public static MegaCacheOBJMtl GetMtl(int i)
	{
		return null;
	}

	public static Mesh ImportFile(string filePath, float scale, bool adjust, bool tangents, bool loadmtls, bool optimize, bool recalcnormals)
	{
		return null;
	}

	public static string ReadLine(string input)
	{
		return null;
	}

	public static string ReadLineMtl(string input)
	{
		return null;
	}

	private static void populateMeshStructNew(string entireText, ref MegaCacheOBJMesh mesh, bool loadmtls)
	{
	}

	public static void ImportMtl(string filePath)
	{
	}

	private static MegaCacheOBJMtl HaveMaterial(string name)
	{
		return null;
	}

	private static int GetMtlID(string name)
	{
		return 0;
	}

	private static void LoadMtlLib(string filename)
	{
	}
}
