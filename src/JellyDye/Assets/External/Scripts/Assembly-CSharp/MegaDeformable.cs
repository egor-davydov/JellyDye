using UnityEngine;

public class MegaDeformable : MegaModifier
{
	public float Hardness;

	public bool DeformMeshCollider;

	public float UpdateFrequency;

	public float MaxVertexMov;

	public Color32 DeformedVertexColor;

	public Texture2D HardnessMap;

	public bool usedecay;

	public float decay;

	public Color[] baseColors;

	public float sizeFactor;

	public float[] map;

	public Vector3[] offsets;

	public float impactFactor;

	public float ColForce;

	public MegaModifyObject modobj;

	private ContactPoint[] colpoints;

	public override string ModName()
	{
		return null;
	}

	public override void ModStart(MegaModifiers mc)
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

	public override MegaModChannel ChannelsReq()
	{
		return default(MegaModChannel);
	}

	public override MegaModChannel ChannelsChanged()
	{
		return default(MegaModChannel);
	}

	private void LoadMesh()
	{
	}

	public void LoadMap()
	{
	}

	private void LoadMap(MegaModifiers mc)
	{
	}

	public override void Modify(MegaModifiers mc)
	{
	}

	public void Repair(float repair, MegaModifiers mc)
	{
	}

	public void Repair(float repair, Vector3 point, float radius, MegaModifiers mc)
	{
	}

	private void OnCollisionEnter(Collision collision)
	{
	}

	private void OnCollisionStay(Collision collision)
	{
	}

	private void OnCollisionExit(Collision collision)
	{
	}
}
