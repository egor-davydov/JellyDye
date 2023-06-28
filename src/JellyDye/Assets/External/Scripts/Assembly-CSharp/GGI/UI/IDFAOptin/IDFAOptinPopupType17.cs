using Gjg.Io.GameConfig.Proto.Config.V3.Resources;

namespace GGI.UI.IDFAOptin
{
	public class IDFAOptinPopupType17
	{
		private bool _moreInfoTransitioned;

		private bool _yesOnce;

		private int _currentMultipleIndex;

		public bool OnChoice(bool choice)
		{
			return false;
		}

		public void Activate()
		{
		}

		public void TransitionBase()
		{
		}

		public void TransitionToMultiple(int index, long textId)
		{
		}

		private void CallNative(int btnCount, string title, string desc, string yes, string no)
		{
		}

		private OptinConfig GetConfig()
		{
			return null;
		}

		public void Refresh()
		{
		}
	}
}
