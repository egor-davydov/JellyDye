using UnityEngine;

public class MegaBubble : MegaModifier
{
	public float radius;

	public float falloff;

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

	public override bool Prepare(MegaModContext mc)
	{
		return false;
	}
}
