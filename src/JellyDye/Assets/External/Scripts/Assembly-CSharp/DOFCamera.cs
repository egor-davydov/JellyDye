using UnityEngine;

[ExecuteInEditMode]
public class DOFCamera : MonoBehaviour
{
	public Camera srcCamera;

	public float sampleRadius;

	public float alpha;

	public float focalDistance;

	private Vector3 tpos;

	private void Update()
	{
	}

	public void OnDrawGizmos()
	{
	}
}
