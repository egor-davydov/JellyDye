using UnityEngine;

public class MegaVolSelect : MegaSelectionMod
{
	private float[] modselection;

	public Vector3 origin;

	public float falloff;

	public float radius;

	public Color gizCol;

	public float gizSize;

	public bool useCurrentVerts;

	public bool displayWeights;

	public bool freezeSelection;

	public MegaVolumeType volType;

	public Vector3 boxsize;

	public float weight;

	public bool inverse;

	public Transform target;

	public override MegaModChannel ChannelsReq()
	{
		return default(MegaModChannel);
	}

	public override string ModName()
	{
		return null;
	}

	public override string GetHelpURL()
	{
		return null;
	}

	public float[] GetSel()
	{
		return null;
	}

	private float GetDistBox(Vector3 p)
	{
		return 0f;
	}

	public override void GetSelection(MegaModifiers mc)
	{
	}

	public override void DrawGizmo(MegaModContext context)
	{
	}
}
