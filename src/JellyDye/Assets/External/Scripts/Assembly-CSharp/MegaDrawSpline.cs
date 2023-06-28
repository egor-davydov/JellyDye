using UnityEngine;

public class MegaDrawSpline : MonoBehaviour
{
	public float updatedist;

	public float smooth;

	public Material mat;

	public float width;

	public float height;

	public float radius;

	public bool closed;

	public MeshShapeType meshtype;

	public float offset;

	public float tradius;

	public float meshstep;

	public float closevalue;

	public bool constantspd;

	private GameObject obj;

	private Vector3 lasthitpos;

	private bool building;

	private float travelled;

	private Vector3 lastdir;

	private MegaSpline cspline;

	private MegaShape cshape;

	private int splinecount;

	private void Update()
	{
	}

	private bool ValidSpline()
	{
		return false;
	}

	public MegaSpline NewSpline(MegaShape shape)
	{
		return null;
	}

	private GameObject CreateSpline(Vector3 pos)
	{
		return null;
	}

	private void FinishSpline(GameObject obj, Vector3 p)
	{
	}

	private void OnDrawGizmosSelected()
	{
	}
}
