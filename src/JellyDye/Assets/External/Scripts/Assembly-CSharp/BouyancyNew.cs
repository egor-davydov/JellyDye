using System.Collections.Generic;
using UnityEngine;

public class BouyancyNew : MonoBehaviour
{
	public float density;

	public int slicesPerAxis;

	public bool isConcave;

	public int voxelsLimit;

	private const float DAMPFER = 0.1f;

	private const float WATER_DENSITY = 1000f;

	private float voxelHalfHeight;

	private Vector3 localArchimedesForce;

	private List<Vector3> voxels;

	private bool isMeshCollider;

	public GameObject water;

	public MegaDynamicRipple dynamicwater;

	private Transform dwtrans;

	private Rigidbody rbody;

	private Collider mycollider;

	public float ripplevel;

	public float rippleforce;

	private void Start()
	{
	}

	private List<Vector3> SliceIntoVoxels(bool concave)
	{
		return null;
	}

	private static bool PointIsInsideMeshCollider(Collider c, Vector3 p)
	{
		return false;
	}

	private static void FindClosestPoints(IList<Vector3> list, out int firstIndex, out int secondIndex)
	{
		firstIndex = default(int);
		secondIndex = default(int);
	}

	private static void WeldPoints(IList<Vector3> list, int targetCount)
	{
	}

	private float GetWaterLevel(float x, float z)
	{
		return 0f;
	}

	private void FixedUpdate()
	{
	}

	private void OnDrawGizmos()
	{
	}
}
