namespace GGI.Digger
{
	public static class Digger
	{
		public enum FirstSessionMode
		{
			Undefined = 0,
			Rescan = 1,
			Smart = 2
		}

		public enum Mode
		{
			Undefined = 0,
			Rescan = 1,
			LastImpression = 2,
			FirstSessionFirstImpression = 3,
			FirstSessionLastImpression = 4,
			LastSessionFirstImpression = 5,
			Highest = 6
		}

		public static readonly float DefaultStep;

		public static readonly float DefaultStartStep;

		public static readonly float DefaultResetStep;

		private static bool _logConfigFetched;

		private static bool _logsEnabled;

		private static int _version;

		public static string FirstSessionModeString(FirstSessionMode mode)
		{
			return null;
		}

		public static string ModeString(Mode mode)
		{
			return null;
		}

		public static FirstSessionMode ChooseFirstSessionMode(int mode)
		{
			return default(FirstSessionMode);
		}

		public static Mode ChooseMode(int mode)
		{
			return default(Mode);
		}

		public static void Log(string log)
		{
		}

		public static void LogError(string log)
		{
		}

		public static bool VersionMatched()
		{
			return false;
		}
	}
}
