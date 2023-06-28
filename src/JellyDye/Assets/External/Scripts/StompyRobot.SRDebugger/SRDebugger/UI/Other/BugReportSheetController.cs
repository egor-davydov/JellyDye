using System;
using System.Collections;
using SRF;
using UnityEngine;
using UnityEngine.UI;

namespace SRDebugger.UI.Other
{
	public class BugReportSheetController : SRMonoBehaviourEx
	{
		[RequiredField]
		public GameObject ButtonContainer;

		[RequiredField]
		public Text ButtonText;

		[RequiredField]
		public Button CancelButton;

		public Action CancelPressed;

		[RequiredField]
		public InputField DescriptionField;

		[RequiredField]
		public InputField EmailField;

		[RequiredField]
		public Slider ProgressBar;

		[RequiredField]
		public Text ResultMessageText;

		public Action ScreenshotComplete;

		[RequiredField]
		public Button SubmitButton;

		public Action<bool, string> SubmitComplete;

		public Action TakingScreenshot;

		public bool IsCancelButtonEnabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		protected override void Start()
		{
		}

		public void Submit()
		{
		}

		public void Cancel()
		{
		}

		private IEnumerator SubmitCo()
		{
			return null;
		}

		private void OnBugReportProgress(float progress)
		{
		}

		private void OnBugReportComplete(bool didSucceed, string errorMessage)
		{
		}

		protected void SetLoadingSpinnerVisible(bool visible)
		{
		}

		protected void ClearForm()
		{
		}

		protected void ShowErrorMessage(string userMessage, string serverMessage = null)
		{
		}

		protected void ClearErrorMessage()
		{
		}

		protected void SetFormEnabled(bool e)
		{
		}

		private string GetDefaultEmailFieldContents()
		{
			return null;
		}

		private void SetDefaultEmailFieldContents(string value)
		{
		}
	}
}
