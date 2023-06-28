using System;

[Serializable]
public class MegaMorphAnimClip
{
	public string name;

	public float start;

	public float end;

	public MegaRepeatMode loop;

	public float speed;

	public MegaMorphAnimClip(string _name, float _start, float _end, MegaRepeatMode _loop)
	{
	}
}
