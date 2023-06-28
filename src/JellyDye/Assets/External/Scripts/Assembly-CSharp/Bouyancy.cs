using UnityEngine;

public class Bouyancy : MonoBehaviour
{
	public float waterLevel;

	public float floatHeight;

	public Vector3 buoyancyCentreOffset;

	public float bounceDamp;

	public GameObject water;

	public MegaDynamicRipple dynamicwater;

	private Rigidbody rbody;

	private void Start()
	{
	}

	private void FixedUpdate()
	{
	}
}
