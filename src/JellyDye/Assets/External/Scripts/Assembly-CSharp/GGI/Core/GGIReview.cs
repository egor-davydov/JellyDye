using GGI.Components;
using GGI.UI.RateUS;

namespace GGI.Core
{
	public class GGIReview : AutoSingletonMono<GGIReview>
	{
		public RateUsPanelMiddle RateUsPanel;

		private int _lastShowedLevel;

		protected override void Awake()
		{
		}

		public bool ShouldShowThisLevel()
		{
			return false;
		}

		public void Show()
		{
		}

		public void OnNoButtonClicked()
		{
		}

		public void OnYesButtonClicked()
		{
		}

		public GGIReview()
		{
			((AutoSingletonMono<>)(object)this)._002Ector();
		}
	}
}
