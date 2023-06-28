using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class MegaPointCacheAnimator : MonoBehaviour
{
	public MegaPointCache mod;

	public MegaPointCacheRef modref;

	public List<MegaPointCacheAnimClip> clips;

	public int current;

	public float t;

	public float at;

	public int sourceFPS;

	public bool useFrames;

	public bool LinkedUpdate;

	public bool PlayOnStart;

	private Animation myanim;

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
