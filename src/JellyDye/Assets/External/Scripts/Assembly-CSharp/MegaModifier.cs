using System;
using UnityEngine;

public class MegaModifier : MonoBehaviour
{
	[HideInInspector]
	public bool ModEnabled;

	[HideInInspector]
	public bool DisplayGizmo;

	[HideInInspector]
	public int Order;

	[HideInInspector]
	public Vector3 Offset;

	[HideInInspector]
	public Vector3 gizmoPos;

	[HideInInspector]
	public Vector3 gizmoRot;

	[HideInInspector]
	public Vector3 gizmoScale;

	[HideInInspector]
	public Color gizCol1;

	[HideInInspector]
	public Color gizCol2;

	[NonSerialized]
	[HideInInspector]
	public Matrix4x4 tm;

	[NonSerialized]
	public Matrix4x4 invtm;

	[HideInInspector]
	public MegaBox3 bbox;

	[HideInInspector]
	public Vector3[] corners;

	[HideInInspector]
	public int steps;

	[HideInInspector]
	public Vector3[] verts;

	[HideInInspector]
	public Vector3[] sverts;

	[HideInInspector]
	public bool valid;

	[HideInInspector]
	public float[] selection;

	[HideInInspector]
	public MegaModifier instance;

	public bool limitchandisplay;

	public int startchannel;

	public int displaychans;

	public bool useUndo;

	[HideInInspector]
	public string Label;

	[HideInInspector]
	public int MaxLOD;

	public virtual MegaModChannel ChannelsReq()
	{
		return default(MegaModChannel);
	}

	public virtual MegaModChannel ChannelsChanged()
	{
		return default(MegaModChannel);
	}

	public virtual float GizmoSize()
	{
		return 0f;
	}

	public virtual void ModStart(MegaModifiers ms)
	{
	}

	public virtual void ModUpdate()
	{
	}

	public virtual bool ModLateUpdate(MegaModContext mc)
	{
		return false;
	}

	public virtual Vector3 Map(int i, Vector3 p)
	{
		return default(Vector3);
	}

	public virtual void ShowGUI()
	{
	}

	public virtual string ModName()
	{
		return null;
	}

	public virtual bool InitMod(MegaModifiers mc)
	{
		return false;
	}

	public virtual bool Prepare(MegaModContext mc)
	{
		return false;
	}

	public virtual void ModEnd(MegaModifiers ms)
	{
	}

	public virtual string GetHelpURL()
	{
		return null;
	}

	public virtual void PrepareMT(MegaModifiers mc, int cores)
	{
	}

	public virtual void DoneMT(MegaModifiers mc)
	{
	}

	public virtual void SetValues(MegaModifier mod)
	{
	}

	public virtual bool CanThread()
	{
		return false;
	}

	public virtual void Copy(MegaModifier dst)
	{
	}

	public virtual void PostCopy(MegaModifier dst)
	{
	}

	public virtual void DoWork(MegaModifiers mc, int index, int start, int end, int cores)
	{
	}

	public virtual void DoWorkWeighted(MegaModifiers mc, int index, int start, int end, int cores)
	{
	}

	private void Awake()
	{
	}

	private void Reset()
	{
	}

	public void Help()
	{
	}

	public void ResetOffset()
	{
	}

	private Vector3 GetCentre()
	{
		return default(Vector3);
	}

	public void ResetGizmoPos()
	{
	}

	public void ResetGizmoRot()
	{
	}

	public void ResetGizmoScale()
	{
	}

	public void CentreOffset()
	{
	}

	public void CentreGizmoPos()
	{
	}

	public void SetModMesh(Mesh ms)
	{
	}

	public virtual void MeshChanged()
	{
	}

	public void SetTM()
	{
	}

	public void SetTM(Vector3 off)
	{
	}

	public void SetAxis(Matrix4x4 tmAxis)
	{
	}

	public virtual void Modify(ref Vector3[] sverts, ref Vector3[] verts)
	{
	}

	public virtual void Modify(Vector3[] sverts, Vector3[] verts)
	{
	}

	public virtual void Modify(MegaModifiers mc)
	{
	}

	public virtual void ModifyWeighted(MegaModifiers mc)
	{
	}

	public void DrawEdge(Vector3 p1, Vector3 p2)
	{
	}

	public void DrawEdgeCol(Vector3 p1, Vector3 p2)
	{
	}

	public virtual void DrawGizmo(MegaModContext context)
	{
	}

	public virtual void ExtraGizmo(MegaModContext mc)
	{
	}

	public void DrawFromTo(MegaAxis axis, float from, float to, MegaModContext mc)
	{
	}

	private void OnDrawGizmosSelected()
	{
	}
}
