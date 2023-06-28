using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Firebase.Crashlytics
{
	internal class LoggedException : Exception
	{
		public string Name
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public string CustomStackTrace
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public Dictionary<string, string>[] ParsedStackTrace
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public LoggedException(string name, string message, string stackTrace)
		{
		}

		public static LoggedException FromException(Exception exception)
		{
			return null;
		}
	}
}
