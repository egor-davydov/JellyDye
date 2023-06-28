public class MegaPointCacheRef : MegaModifier
{
	public float time;

	public bool animated;

	public float speed;

	public float maxtime;

	public MegaRepeatMode LoopMode;

	public MegaInterpMethod interpMethod;

	public MegaPointCache source;

	public float weight;

	public MegaBlendAnimMode blendMode;

	private float t;

	private float alpha;

	private float dalpha;

	private int sindex;

	private int sindex1;

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
