public class MegaVertexAnim : MegaModifier
{
	public float time;

	public bool animated;

	public float speed;

	public float maxtime;

	public int[] NoAnim;

	public float weight;

	public MegaAnimatedVert[] Verts;

	private float t;

	public MegaBlendAnimMode blendMode;

	public MegaRepeatMode LoopMode;

	public override string ModName()
	{
		return null;
	}

	public override string GetHelpURL()
	{
		return null;
	}

	private void Replace(MegaModifiers mc, int startvert, int endvert)
	{
	}

	private void ReplaceWeighted(MegaModifiers mc, int startvert, int endvert)
	{
	}

	private void Additive(MegaModifiers mc, int startvert, int endvert)
	{
	}

	private void AdditiveWeighted(MegaModifiers mc, int startvert, int endvert)
	{
	}

	public override void Modify(MegaModifiers mc)
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
