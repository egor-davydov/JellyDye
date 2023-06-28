namespace Firebase.Platform.Default
{
	internal class SystemClock : IClockService
	{
		public static readonly IClockService Instance;

		protected SystemClock()
		{
		}
	}
}
