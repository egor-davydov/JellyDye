using System.Collections.Generic;
using UnityEngine;

public class MegaMultiVolSelect : MegaSelectionMod
{
	private float[] modselection;

	public Color gizCol;

	public float gizSize;

	public bool useCurrentVerts;

	public bool displayWeights;

	public bool freezeSelection;

	public List<MegaVolume> volumes;

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

	private float GetDistBox(MegaVolume vol, Vector3 p)
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
