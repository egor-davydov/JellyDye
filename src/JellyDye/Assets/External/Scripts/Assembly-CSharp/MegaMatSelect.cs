public class MegaMatSelect : MegaSelectionMod
{
	public int matnum;

	private float[] modselection;

	public float gizSize;

	public bool displayWeights;

	public bool update;

	public float weight;

	public float otherweight;

	public override MegaModChannel ChannelsReq()
	{
		return default(MegaModChannel);
	}

	public override string ModName()
	{
		return null;
	}

	public override string GetHelpURL()
	{
		return null;
	}

	public float[] GetSel()
	{
		return null;
	}

	public override void GetSelection(MegaModifiers mc)
	{
	}
}
