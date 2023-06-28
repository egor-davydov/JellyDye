using Sirenix.OdinInspector;
using UnityEngine;

[CreateAssetMenu]
public class ColorData : SerializedScriptableObject
{
	public Color Main;

	public Color Shadow;

	public Material MaterialToCopyFrom;

	[Button]
	public void CopyFromMaterial()
	{
	}
}
