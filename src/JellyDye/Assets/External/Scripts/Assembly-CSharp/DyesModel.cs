using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class DyesModel
{
	public List<DyeModel> Dyes;

	public Color GetCurrentColor(float amount)
	{
		return default(Color);
	}

	public DyeModel GetActiveDye(float amount)
	{
		return null;
	}

	public float GetDifferenceAmount(float amount)
	{
		return 0f;
	}
}
