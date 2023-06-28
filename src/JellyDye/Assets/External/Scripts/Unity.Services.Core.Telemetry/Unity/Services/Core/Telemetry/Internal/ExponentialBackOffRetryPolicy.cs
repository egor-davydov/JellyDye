namespace Unity.Services.Core.Telemetry.Internal
{
	internal class ExponentialBackOffRetryPolicy
	{
		private int m_MaxTryCount;

		private float m_BaseDelaySeconds;

		public int MaxTryCount => 0;

		public float BaseDelaySeconds => 0f;

		public bool CanRetry(WebRequest webRequest, int sendCount)
		{
			return false;
		}

		public static bool IsTransientError(WebRequest webRequest)
		{
			return false;
		}

		public float GetDelayBeforeSendingSeconds(int sendCount)
		{
			return 0f;
		}
	}
}
