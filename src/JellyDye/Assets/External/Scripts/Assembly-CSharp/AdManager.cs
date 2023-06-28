public class AdManager : MonoSingleton<AdManager>
{
	public float _timer;

	public float _noInterTimer;

	public bool IsQueued;

	public bool IsFirstLevel;

	public bool IsActive;

	private float SessionNoInterTimer;

	private float StopDyeTimer;

	private float PickColorTimer;

	private float NextButtonTimer;

	private float LevelEndTimer;

	public void OnLevelStart()
	{
	}

	private void Update()
	{
	}

	public void OnStopDye()
	{
	}

	public void OnPickColor()
	{
	}

	public void OnNextPiece()
	{
	}

	public void OnLevelEnd()
	{
	}

	private void ShowAggressiveInter()
	{
	}

	public AdManager()
	{
		((MonoSingleton<>)(object)this)._002Ector();
	}
}
