using UnityEngine;

public class MegaFFD2x2x2 : MegaFFD
{
	public override string ModName()
	{
		return null;
	}

	public override int GridSize()
	{
		return 0;
	}

	public override Vector3 Map(int ii, Vector3 p)
	{
		return default(Vector3);
	}

	public override int GridIndex(int i, int j, int k)
	{
		return 0;
	}
}
