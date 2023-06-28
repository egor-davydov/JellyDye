using System.Collections.Generic;
using UnityEngine;

public class DripAnimManager : MonoSingleton<DripAnimManager>
{
	public List<Texture2D> Textures;

	public float BumpUvMultiplier;

	public int SkipFrame;

	private int _skippedFrames;

	private int _currentFrame;

	private bool _isAnimating;

	private Material _activeMat;

	private void Start()
	{
	}

	public void StartAnim(SkinnedMeshRenderer mesh, Vector2 uv)
	{
	}

	private void EndAnim()
	{
	}

	public void Update()
	{
	}

	public DripAnimManager()
	{
		((MonoSingleton<>)(object)this)._002Ector();
	}
}
