using UnityEngine;

public class MegaPointCache : MegaModifier
{
	public float time;

	public bool animated;

	public float speed;

	public float maxtime;

	public MegaRepeatMode LoopMode;

	public MegaInterpMethod interpMethod;

	public MegaPCVert[] Verts;

	public float weight;

	public bool framedelay;

	public bool ignoreFirst;

	public MegaBlendAnimMode blendMode;

	private int numPoints;

	private float startFrame;

	private float sampleRate;

	private int numSamples;

	private float t;

	private float alpha;

	private float dalpha;

	private int sindex;

	private int sindex1;

	public bool showmapping;

	public float mappingSize;

	public int mapStart;

	public int mapEnd;

	public bool havemapping;

	public float scl;

	public bool flipyz;

	public bool negx;

	public bool negz;

	public float adjustscl;

	public Vector3 adjustoff;

	private bool skipframe;

	public override string ModName()
	{
		return null;
	}

	public override string GetHelpURL()
	{
		return null;
	}

	private void LinearAbs(MegaModifiers mc, int start, int end)
	{
	}

	private void LinearAbsWeighted(MegaModifiers mc, int start, int end)
	{
	}

	private void LinearRel(MegaModifiers mc, int start, int end)
	{
	}

	private void LinearRelWeighted(MegaModifiers mc, int start, int end)
	{
	}

	private void NoInterpAbs(MegaModifiers mc, int start, int end)
	{
	}

	private void NoInterpAbsWeighted(MegaModifiers mc, int start, int end)
	{
	}

	private void NoInterpRel(MegaModifiers mc, int start, int end)
	{
	}

	private void NoInterpRelWeighted(MegaModifiers mc, int start, int end)
	{
	}

	public override void Modify(MegaModifiers mc)
	{
	}

	public void ModifyInstance(MegaModifiers mc, float itime)
	{
	}

	public void SetAnim(float _t)
	{
	}

	public override bool ModLateUpdate(MegaModContext mc)
	{
		return false;
	}

	public override bool Prepare(MegaModContext mc)
	{
		return false;
	}

	public override void DoWork(MegaModifiers mc, int index, int start, int end, int cores)
	{
	}

	public void ModifyCompressedMT(MegaModifiers mc, int tindex, int cores)
	{
	}
}
