namespace GGI.Analytics
{
	public static class StaticEventParameters
	{
		private static AppInfo _appInfo;

		private static int _processorFrequency;

		private static int _processorCount;

		private static string _processorType;

		private static DeviceData _device => null;

		public static DeviceData Device => null;

		public static AppInfo AppInfo => null;

		public static int ProcessorFrequency => 0;

		public static int ProcessorCount => 0;

		public static string ProcessorType => null;
	}
}
