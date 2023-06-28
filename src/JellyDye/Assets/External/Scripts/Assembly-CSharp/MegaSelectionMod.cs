public class MegaSelectionMod : MegaModifier
{
	public override MegaModChannel ChannelsChanged()
	{
		return default(MegaModChannel);
	}

	public virtual void GetSelection(MegaModifiers mc)
	{
	}

	public override bool ModLateUpdate(MegaModContext mc)
	{
		return false;
	}

	public override void DrawGizmo(MegaModContext context)
	{
	}

	public override void DoWork(MegaModifiers mc, int index, int start, int end, int cores)
	{
	}
}
