using UnityEngine;

[ExecuteInEditMode]
public class MegaWalkRope : MonoBehaviour
{
	public GameObject bridge;

	[HideInInspector]
	public MegaRopeDeform mod;

	public float offset;

	public bool checkonbridge;

	public float weight;

	private Mesh mesh;

	private void LateUpdate()
	{
	}

	public void SetPos(MegaRopeDeform mod, float alpha)
	{
	}
}
