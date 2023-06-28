using System;
using UnityEngine;

[ExecuteInEditMode]
public class MegaWarp : MonoBehaviour
{
	public float Width;

	public float Height;

	public float Length;

	public float Decay;

	public bool Enabled;

	public bool DisplayGizmo;

	public Color GizCol1;

	public Color GizCol2;

	[NonSerialized]
	public Matrix4x4 tm;

	[NonSerialized]
	public Matrix4x4 invtm;

	private Vector3 Offset;

	private int steps;

	[NonSerialized]
	public float totaldecay;

	[HideInInspector]
	public Vector3[] corners;

	public static Color gCol1;

	public static Color gCol2;

	public virtual string WarpName()
	{
		return null;
	}

	public virtual string GetHelpURL()
	{
		return null;
	}

	public virtual Vector3 Map(int i, Vector3 p)
	{
		return default(Vector3);
	}

	public virtual bool Prepare(float decay)
	{
		return false;
	}

	public virtual string GetIcon()
	{
		return null;
	}

	public void Help()
	{
	}

	public virtual void SetAxis(Matrix4x4 tmAxis)
	{
	}

	public void DrawEdge(Vector3 p1, Vector3 p2)
	{
	}

	public void DrawEdgeCol(Vector3 p1, Vector3 p2)
	{
	}

	public void SetGizCols(float a)
	{
	}

	public virtual void DrawGizmo(Color col)
	{
	}

	public virtual void ExtraGizmo()
	{
	}

	public void DrawFromTo(MegaAxis axis, float from, float to)
	{
	}
}
