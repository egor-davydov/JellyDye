using System;
using System.Runtime.CompilerServices;
using GGI.Components;
using GGI.Internal.GDPR.Data;

namespace GGI.Internal.GDPR
{
	public class GDPR : AutoSingleton<GDPR>
	{
		private Action<SessionConsentResult> _completeAction;

		public SessionConsentResult SessionConsentResult
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

		public void Start(string userAdvertisingId, Action<SessionConsentResult> onComplete)
		{
		}

		public void GiveConsent(bool adsConsent)
		{
		}

		private void OnSetConsentError()
		{
		}

		private void OnSetConsentSuccess()
		{
		}

		public GDPR()
		{
			((AutoSingleton<>)(object)this)._002Ector();
		}
	}
}
