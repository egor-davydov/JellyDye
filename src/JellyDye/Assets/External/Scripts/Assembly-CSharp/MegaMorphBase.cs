using System;
using System.Collections.Generic;

public class MegaMorphBase : MegaModifier
{
	[Serializable]
	public class MegaMorphBlend
	{
		public float t;

		public float weight;
	}

	public List<MegaMorphChan> chanBank;

	public MegaMorphAnimType animtype;

	public int numblends;

	public List<MegaMorphBlend> blends;

	public override void PostCopy(MegaModifier src)
	{
	}

	public string[] GetChannelNames()
	{
		return null;
	}

	public MegaMorphChan GetChannel(string name)
	{
		return null;
	}

	public int NumChannels()
	{
		return 0;
	}

	public void SetPercent(int i, float percent)
	{
	}

	public void SetPercentLim(int i, float alpha)
	{
	}

	public void SetPercent(int i, float percent, float speed)
	{
	}

	public void ResetPercent(int[] channels, float speed)
	{
	}

	public float GetPercent(int i)
	{
		return 0f;
	}

	public void SetAnim(float t)
	{
	}

	public void SetAnimBlend(float t, float weight)
	{
	}

	public void ClearBlends()
	{
	}

	public void SetChannels()
	{
	}
}
