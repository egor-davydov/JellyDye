using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using SRDebugger.Services;
using UnityEngine.Networking;

namespace SRDebugger.Internal
{
	public class BugReportApi
	{
		private readonly string _apiKey;

		private readonly BugReport _bugReport;

		private bool _isBusy;

		private UnityWebRequest _webRequest;

		public bool IsComplete
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool WasSuccessful
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public string ErrorMessage
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

		public float Progress => 0f;

		public BugReportApi(BugReport report, string apiKey)
		{
		}

		public IEnumerator Submit()
		{
			return null;
		}

		private void SetCompletionState(bool wasSuccessful)
		{
		}

		private static string BuildJsonRequest(BugReport report)
		{
			return null;
		}

		private static IList<IList<string>> CreateConsoleDump()
		{
			return null;
		}
	}
}
