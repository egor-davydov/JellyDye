using System;
using UnityEngine;

[Serializable]
public class VertexRubber
{
	public Vector3 pos;

	public Vector3 cpos;

	public Vector3 force;

	public Vector3 acc;

	public Vector3 vel;

	public int[] indices;

	public float weight;

	public float stiff;

	public VertexRubber(Vector3 v_target, float w, float s)
	{
	}
}
