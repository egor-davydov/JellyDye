using System.Threading.Tasks;

namespace Firebase.Analytics
{
	public sealed class FirebaseAnalytics
	{
		private static FirebaseApp app;

		static FirebaseAnalytics()
		{
		}

		public static void LogEvent(string name)
		{
		}

		public static void LogEvent(string name, params Parameter[] parameters)
		{
		}

		public static Task<string> GetAnalyticsInstanceIdAsync()
		{
			return null;
		}
	}
}
