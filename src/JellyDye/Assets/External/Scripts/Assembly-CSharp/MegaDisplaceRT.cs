using UnityEngine;

public class MegaDisplaceRT : MegaModifier
{
	public RenderTexture rtmap;

	public float amount;

	public Vector2 offset;

	public float vertical;

	public Vector2 scale;

	public MegaChannel channel;

	public bool CentLum;

	public float CentVal;

	public float Decay;

	[HideInInspector]
	public Vector2[] uvs;

	[HideInInspector]
	public Vector3[] normals;

	private Texture2D map;

	public override string ModName()
	{
		return null;
	}

	public override string GetHelpURL()
	{
		return null;
	}

	public override MegaModChannel ChannelsReq()
	{
		return default(MegaModChannel);
	}

	public override MegaModChannel ChannelsChanged()
	{
		return default(MegaModChannel);
	}

	public virtual void Init()
	{
	}

	public override void MeshChanged()
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
