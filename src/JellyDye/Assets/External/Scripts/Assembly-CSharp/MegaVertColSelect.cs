public class MegaVertColSelect : MegaSelectionMod
{
	public MegaChannel channel;

	private float[] modselection;

	public float gizSize;

	public bool displayWeights;

	public float weight;

	public float threshold;

	public bool update;

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
