using UnityEngine;

[ExecuteInEditMode]
public class MOrbit : MonoBehaviour
{
	public GameObject target;

	private MeshRenderer render;

	private SkinnedMeshRenderer srender;

	private MeshFilter filter;

	public float distance;

	public float xSpeed;

	public float ySpeed;

	public float zSpeed;

	public float yMinLimit;

	public float yMaxLimit;

	public float xMinLimit;

	public float xMaxLimit;

	private float x;

	private float y;

	private Vector3 center;

	public bool Dynamic;

	public Vector3 offset;

	public Vector3 EditTest;

	private Vector3 tpos;

	private float t;

	public float trantime;

	private float vx;

	private float vy;

	private float vz;

	public float nx;

	public float ny;

	public float nz;

	public float delay;

	public float delayz;

	private void Start()
	{
	}

	private float easeInOutQuint(float start, float end, float value)
	{
		return 0f;
	}

	private float easeInQuad(float start, float end, float value)
	{
		return 0f;
	}

	private float easeInSine(float start, float end, float value)
	{
		return 0f;
	}

	public void NewTarget(GameObject targ)
	{
	}

	private void LateUpdate()
	{
	}

	private static float ClampAngle(float angle, float min, float max)
	{
		return 0f;
	}
}
