using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class MegaMorphAnimator : MonoBehaviour
{
	public MegaMorphBase morph;

	public MegaMorphBase[] morphs;

	public List<MegaMorphAnimClip> clips;

	public List<MegaPlayingClip> playing;

	public int current;

	public float t;

	public float at;

	public int sourceFPS;

	public bool useFrames;

	private Stack<MegaPlayingClip> clippool;

	public bool MultipleMorphs;

	public bool LinkedUpdate;

	public bool PlayOnStart;

	private Animation myanim;

	public void UpdatePlayingClips()
	{
	}

	public void Help()
	{
	}

	public bool IsPlaying()
	{
		return false;
	}

	public void SetTime(float time)
	{
	}

	public float GetTime()
	{
		return 0f;
	}

	public void PlayClipEvent(int i)
	{
	}

	public void PlayClipNameEvent(string name)
	{
	}

	public void PlayClip(int i)
	{
	}

	public void PlayClip(string name)
	{
	}

	public void PlayClip(int i, float blend)
	{
	}

	public void PlayClip(string name, float blend)
	{
	}

	public void Stop()
	{
	}

	public int AddClip(string name, float start, float end, MegaRepeatMode loop)
	{
		return 0;
	}

	public string[] GetClipNames()
	{
		return null;
	}

	private void Start()
	{
	}

	private MegaPlayingClip PopClip()
	{
		return null;
	}

	private void PushClip(MegaPlayingClip clip)
	{
	}

	private void Update()
	{
	}

	private void DoUpdate()
	{
	}

	private void DoLinkedUpdate()
	{
	}
}
