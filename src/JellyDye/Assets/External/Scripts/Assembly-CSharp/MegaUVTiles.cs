using UnityEngine;

public class MegaUVTiles : MegaModifier
{
	public int Frame;

	public int TileWidth;

	public int TileHeight;

	public Vector2 off;

	public Vector2 scale;

	public bool Animate;

	public int EndFrame;

	public float fps;

	public float AnimTime;

	public bool flipy;

	public bool flipx;

	public MegaRepeatMode loopMode;

	[HideInInspector]
	public int twidth;

	[HideInInspector]
	public int theight;

	[HideInInspector]
	public float frm;

	private Material mat;

	private float tuvw;

	private float tuvh;

	private int xtiles;

	private int ytiles;

	private int maxframe;

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

	private void Init()
	{
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
}
