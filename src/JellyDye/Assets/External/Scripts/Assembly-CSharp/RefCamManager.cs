using Sirenix.OdinInspector;
using UnityEngine;

public class RefCamManager : MonoSingleton<RefCamManager>
{
	public Camera Cam;

	public RenderTexture RefTexture;

	public Material JellyMat;

	private void Awake()
	{
	}

	[Button]
	public void OnLevelStart()
	{
	}

	public void OnLevelEnd()
	{
	}

	public RefCamManager()
	{
		((MonoSingleton<>)(object)this)._002Ector();
	}
}
