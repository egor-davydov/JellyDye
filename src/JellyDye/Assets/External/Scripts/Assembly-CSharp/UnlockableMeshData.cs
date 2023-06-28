using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

[CreateAssetMenu]
public class UnlockableMeshData : SerializedScriptableObject
{
	public int Id;

	public bool IsVip;

	public Mesh MidModel;

	public Mesh BaseModel;

	public Mesh Base2Model;

	public List<Material> BaseMaterials;

	public List<Material> Base2Materials;

	public Vector3 BaseRotation;

	public Vector3 Base2Rotation;

	[Button]
	public void STEALBASE()
	{
	}
}
