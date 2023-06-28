using UnityEngine;

public class MegaUVAdjust : MegaModifier
{
	public bool animate;

	public float rotspeed;

	public float spiralspeed;

	public Vector3 speed;

	public float spiral;

	public float spirallim;

	public override MegaModChannel ChannelsReq()
	{
		return default(MegaModChannel);
	}

	public override MegaModChannel ChannelsChanged()
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

	public override Vector3 Map(int i, Vector3 p)
	{
		return default(Vector3);
	}

	public override void Modify(MegaModifiers mc)
	{
	}

	public override bool ModLateUpdate(MegaModContext mc)
	{
		return false;
	}

	public override bool Prepare(MegaModContext mc)
	{
		return false;
	}

	public override void DrawGizmo(MegaModContext context)
	{
	}
}
