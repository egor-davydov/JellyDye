using System.Collections.Generic;

namespace Firebase.Crashlytics
{
	internal class StackTraceParser
	{
		private static readonly string FrameArgsRegex;

		private static readonly string FrameRegexWithoutFileInfo;

		private static readonly string FrameRegexWithFileInfo;

		private static readonly string MonoFilenameUnknownString;

		private static readonly string[] StringDelimiters;

		public static Dictionary<string, string>[] ParseStackTraceString(string stackTrace)
		{
			return null;
		}

		private static Dictionary<string, string> ParseFrameString(string regex, string frameString)
		{
			return null;
		}
	}
}
