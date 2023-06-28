using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class MegaModifyGroup : MegaModifyObject
{
	public List<MegaModifierTarget> targets;

	private static int CompareOrder(MegaModifier m1, MegaModifier m2)
	{
		return 0;
	}

	public override void Resort()
	{
	}

	public override void Help()
	{
	}

	public void GroupResetMeshInfo()
	{
	}

	private void ResetOld()
	{
	}

	private void Update()
	{
	}

	private void LateUpdate()
	{
	}

	private void SetTarget(MegaModifierTarget target)
	{
	}

	public void GroupModify()
	{
	}

	public void SetMesh(MegaModifierTarget target, ref Vector3[] _verts)
	{
	}

	private void BuildTangents(MegaModifierTarget target)
	{
	}

	private Mesh GetMesh(GameObject go)
	{
		return null;
	}

	private Mesh GetMesh1(GameObject go)
	{
		return null;
	}

	public void GroupReStart1(bool force)
	{
	}

	public void AddTarget(GameObject go)
	{
	}

	public void RemoveTarget(GameObject go)
	{
	}

	private void Start()
	{
	}

	public void TestBounds()
	{
	}

	public void GroupModReset(MegaModifier m)
	{
	}

	private void OnDrawGizmosSelected()
	{
	}
}
