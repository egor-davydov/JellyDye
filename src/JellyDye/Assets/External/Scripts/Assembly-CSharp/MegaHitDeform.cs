using UnityEngine;

public class MegaHitDeform : MegaModifier
{
	public float hitradius;

	public float Hardness;

	public float deformlimit;

	public float scaleforce;

	public float maxForce;

	private Vector3[] offsets;

	private float msize;

	public override string ModName()
	{
		return null;
	}

	public override void Modify(MegaModifiers mc)
	{
	}

	public void Deform(Vector3 point, Vector3 normal, float force)
	{
	}

	private void Deform(Collision collision)
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

	public void Repair(float repair)
	{
	}

	public void Repair(float repair, Vector3 point, float radius)
	{
	}

	public void OnCollisionEnter(Collision collision)
	{
	}

	public void OnCollisionStay(Collision collision)
	{
	}
}
