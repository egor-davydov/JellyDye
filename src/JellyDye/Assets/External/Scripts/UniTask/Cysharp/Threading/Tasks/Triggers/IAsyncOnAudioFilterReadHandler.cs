namespace Cysharp.Threading.Tasks.Triggers
{
	public interface IAsyncOnAudioFilterReadHandler
	{
		UniTask<(float[], int)> OnAudioFilterReadAsync();
	}
}
