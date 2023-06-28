using UnityEngine;

public class MegaCylindrify : MegaModifier
{
	public float Percent;

	public float Decay;

	private float size;

	private float per;

	public MegaAxis axis;

	private Matrix4x4 mat;

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

	public override bool ModLateUpdate(MegaModContext mc)
	{
		return false;
	}

	public void SetTM1()
	{
	}

	public override bool Prepare(MegaModContext mc)
	{
		return false;
	}
}
