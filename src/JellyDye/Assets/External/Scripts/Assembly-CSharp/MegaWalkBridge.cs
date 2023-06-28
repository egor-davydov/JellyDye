using UnityEngine;

[ExecuteInEditMode]
public class MegaWalkBridge : MonoBehaviour
{
	public GameObject bridge;

	[HideInInspector]
	public MegaCurveDeform mod;

	public float offset;

	public float smooth;

	private void Update()
	{
	}

	private float easeInOutSine(float start, float end, float value)
	{
		return 0f;
	}

	public void SetPos(MegaCurveDeform mod, float alpha)
	{
	}
}
