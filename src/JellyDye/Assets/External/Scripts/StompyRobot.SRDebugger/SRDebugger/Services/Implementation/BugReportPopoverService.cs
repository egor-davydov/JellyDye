using System.Collections;
using SRDebugger.UI.Other;
using SRF.Service;

namespace SRDebugger.Services.Implementation
{
	public class BugReportPopoverService : SRServiceBase<BugReportPopoverService>
	{
		private BugReportCompleteCallback _callback;

		private bool _isVisible;

		private BugReportPopoverRoot _popover;

		private BugReportSheetController _sheet;

		public bool IsShowingPopover => false;

		public void ShowBugReporter(BugReportCompleteCallback callback, bool takeScreenshotFirst = true, string descriptionText = null)
		{
		}

		private IEnumerator OpenCo(bool takeScreenshot, string descriptionText)
		{
			return null;
		}

		private void SubmitComplete(bool didSucceed, string errorMessage)
		{
		}

		private void CancelPressed()
		{
		}

		private void OnComplete(bool success, string errorMessage, bool close)
		{
		}

		private void TakingScreenshot()
		{
		}

		private void ScreenshotComplete()
		{
		}

		protected override void Awake()
		{
		}

		private void Load()
		{
		}

		public BugReportPopoverService()
		{
			((SRServiceBase<T>)(object)this)._002Ector();
		}
	}
}
