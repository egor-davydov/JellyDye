namespace DG.Tweening
{
	public enum LinkBehaviour
	{
		PauseOnDisable = 0,
		PauseOnDisablePlayOnEnable = 1,
		PauseOnDisableRestartOnEnable = 2,
		PlayOnEnable = 3,
		RestartOnEnable = 4,
		KillOnDisable = 5,
		KillOnDestroy = 6,
		CompleteOnDisable = 7,
		CompleteAndKillOnDisable = 8,
		RewindOnDisable = 9,
		RewindAndKillOnDisable = 10
	}
}
