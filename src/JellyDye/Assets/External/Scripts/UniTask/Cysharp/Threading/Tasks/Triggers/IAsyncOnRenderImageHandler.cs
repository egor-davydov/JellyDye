using UnityEngine;

namespace Cysharp.Threading.Tasks.Triggers
{
	public interface IAsyncOnRenderImageHandler
	{
		UniTask<(RenderTexture, RenderTexture)> OnRenderImageAsync();
	}
}
