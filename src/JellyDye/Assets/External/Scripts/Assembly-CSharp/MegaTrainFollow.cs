using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class MegaTrainFollow : MonoBehaviour
{
	public MegaShape path;

	public int curve;

	public List<MegaCarriage> carriages;

	public float distance;

	public float speed;

	public bool showrays;

	private void Update()
	{
	}
}
