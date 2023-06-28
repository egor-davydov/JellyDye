using System;
using UnityEngine;

[Serializable]
public class Mass2D
{
	public Vector2 pos;

	public Vector2 last;

	public Vector2 force;

	public Vector2 vel;

	public Vector2 posc;

	public Vector2 velc;

	public Vector2 forcec;

	public Vector2 coef1;

	public Vector2 coef2;

	public float mass;

	public float oneovermass;

	public Mass2D(float m, Vector2 p)
	{
	}
}
