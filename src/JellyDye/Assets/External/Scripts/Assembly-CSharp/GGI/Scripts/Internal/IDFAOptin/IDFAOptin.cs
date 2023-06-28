using System;
using System.Runtime.CompilerServices;
using GGI.Components;
using Gjg.Io.GameConfig.Proto.Config.V3.Resources;

namespace GGI.Scripts.Internal.IDFAOptin
{
	public class IDFAOptin : AutoSingleton<IDFAOptin>
	{
		public Action OnIDFAOptinPopupShown;

		public Action OnIDFAOptinPopupClosed;

		public Optin Data
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public void InvokePopupShown()
		{
		}

		public void InvokePopupClosed()
		{
		}

		public bool IsShowing()
		{
			return false;
		}

		public string GetPrefKey(string testId)
		{
			return null;
		}

		public IDFAOptin()
		{
			((AutoSingleton<>)(object)this)._002Ector();
		}
	}
}
