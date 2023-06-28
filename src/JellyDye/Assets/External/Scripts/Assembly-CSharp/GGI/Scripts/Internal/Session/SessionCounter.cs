namespace GGI.Scripts.Internal.Session
{
	public class SessionCounter
	{
		private float _lastSessionSentTime;

		private float _maxSessionDurationSeconds;

		private long _timeSpentInBackground;

		public long GetNewSession()
		{
			return 0L;
		}

		private float TotalSeconds()
		{
			return 0f;
		}

		public void SetTimeSpentInBackground(long time)
		{
		}

		public void Check()
		{
		}

		public void OnApplicationResignOrPause()
		{
		}

		private void Run()
		{
		}

		private void SendSession()
		{
		}
	}
}
