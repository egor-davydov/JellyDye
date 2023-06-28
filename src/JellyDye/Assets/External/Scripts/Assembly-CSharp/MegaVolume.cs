using System;
using UnityEngine;

[Serializable]
public class MegaVolume
{
	public bool enabled;

	public float weight;

	public string name;

	public Color regcol;

	public Vector3 origin;

	public Vector3 boxsize;

	public float falloff;

	public MegaVolumeType volType;

	public float radius;

	public bool uselimits;

	public Vector3 size;

	public Transform target;

	public bool inverse;

	public static MegaVolume Create()
	{
		return null;
	}
}
