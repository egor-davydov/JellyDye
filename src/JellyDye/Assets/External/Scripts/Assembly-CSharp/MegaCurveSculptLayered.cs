using System.Collections.Generic;
using UnityEngine;

public class MegaCurveSculptLayered : MegaModifier
{
	public List<MegaSculptCurve> curves;

	private Vector3 size;

	private static object resourceLock;

	public override string ModName()
	{
		return null;
	}

	public override string GetHelpURL()
	{
		return null;
	}

	public override void DoWork(MegaModifiers mc, int index, int start, int end, int cores)
	{
	}

	public override void DoWorkWeighted(MegaModifiers mc, int index, int start, int end, int cores)
	{
	}

	public Vector3 MapMT(int i, Vector3 p)
	{
		return default(Vector3);
	}

	public override Vector3 Map(int i, Vector3 p)
	{
		return default(Vector3);
	}

	public override bool ModLateUpdate(MegaModContext mc)
	{
		return false;
	}

	public override bool Prepare(MegaModContext mc)
	{
		return false;
	}

	public override void DrawGizmo(MegaModContext context)
	{
	}
}
