using UnityEngine;

public class MegaRadialSkew : MegaModifier
{
	public float angle;

	public MegaAxis axis;

	public MegaAxis eaxis;

	public bool biaxial;

	public override string ModName()
	{
		return null;
	}

	public override string GetHelpURL()
	{
		return null;
	}

	private Vector3 GetSkew(Vector3 p)
	{
		return default(Vector3);
	}

	public override Vector3 Map(int i, Vector3 p)
	{
		return default(Vector3);
	}
}
