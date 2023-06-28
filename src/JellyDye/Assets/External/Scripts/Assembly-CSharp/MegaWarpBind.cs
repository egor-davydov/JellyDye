using UnityEngine;

public class MegaWarpBind : MegaModifier
{
	public GameObject SourceWarpObj;

	private GameObject current;

	public float decay;

	private MegaWarp warp;

	public override string ModName()
	{
		return null;
	}

	public override string GetHelpURL()
	{
		return null;
	}

	public void AddSiblings()
	{
	}

	public override Vector3 Map(int i, Vector3 p)
	{
		return default(Vector3);
	}

	public override bool ModLateUpdate(MegaModContext mc)
	{
		return false;
	}

	public override bool Prepare(MegaModContext mc)
	{
		return false;
	}

	public void SetTarget(GameObject go)
	{
	}

	public override void Modify(MegaModifiers mc)
	{
	}

	public override void ModStart(MegaModifiers mc)
	{
	}
}
