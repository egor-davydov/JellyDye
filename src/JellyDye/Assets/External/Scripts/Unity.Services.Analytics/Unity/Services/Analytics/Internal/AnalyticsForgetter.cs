using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Networking;

namespace Unity.Services.Analytics.Internal
{
	internal class AnalyticsForgetter : IAnalyticsForgetter
	{
		private readonly string s_CollectUrl;

		private readonly byte[] s_Event;

		private readonly Action s_Callback;

		private bool m_SuccessfullyUploaded;

		private UnityWebRequestAsyncOperation m_Request;

		private IConsentTracker ConsentTracker
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public AnalyticsForgetter(string collectUrl, string userId, string timestamp, string callingMethod, Action successfulUploadCallback, IConsentTracker consentTracker = null)
		{
		}

		public void AttemptToForget()
		{
		}

		private void UploadComplete(AsyncOperation _)
		{
		}
	}
}
