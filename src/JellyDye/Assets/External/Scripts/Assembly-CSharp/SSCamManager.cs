using System.Collections;
using Sirenix.OdinInspector;
using UnityEngine;

public class SSCamManager : MonoSingleton<SSCamManager>
{
	private Camera _cam;

	public RenderTexture GalleryTexture;

	public RenderTexture RefTexture;

	private void Awake()
	{
	}

	[Button]
	public void TakePieceShot()
	{
	}

	private IEnumerator ScreenshotCoroutine()
	{
		return null;
	}

	public Sprite LoadLevelImage(int level)
	{
		return null;
	}

	public SSCamManager()
	{
		((MonoSingleton<>)(object)this)._002Ector();
	}
}
