using UnityEngine;

public class MegaPush : MegaModifier
{
	public float amount;

	public MegaNormType method;

	private Vector3[] normals;

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

	private void CalcNormals(Mesh mesh)
	{
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

	private void Reset()
	{
	}
}
