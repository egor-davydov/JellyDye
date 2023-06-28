using System;
using UnityEngine;

namespace Firebase.Crashlytics
{
	internal class ExceptionHandler
	{
		private bool isRegistered;

		internal void Register()
		{
		}

		internal void HandleException(object sender, UnhandledExceptionEventArgs eArgs)
		{
		}

		internal void HandleLog(string message, string stackTraceString, LogType type)
		{
		}

		private string[] getMessageParts(string message)
		{
			return null;
		}

		internal virtual void LogException(LoggedException e)
		{
		}
	}
}
