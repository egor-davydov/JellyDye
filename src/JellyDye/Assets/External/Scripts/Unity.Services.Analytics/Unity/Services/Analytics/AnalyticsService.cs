namespace Unity.Services.Analytics
{
	public static class AnalyticsService
	{
		internal static AnalyticsServiceInstance internalInstance;

		public static IAnalyticsService Instance => null;
	}
}
