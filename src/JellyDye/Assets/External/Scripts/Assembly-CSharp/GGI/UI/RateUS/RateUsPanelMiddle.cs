using System;
using GGI.Components;
using UnityEngine;
using UnityEngine.UI;

namespace GGI.UI.RateUS
{
	public class RateUsPanelMiddle : AutoSingletonMono<RateUsPanelMiddle>
	{
		[SerializeField]
		private Text _reviewText;

		[SerializeField]
		private Button _yesButton;

		[SerializeField]
		private Button _noButton;

		private void Update()
		{
		}

		public void Open(Action onComplete = null)
		{
		}

		public void Close(Action onComplete = null)
		{
		}

		public void OnYes(Action onComplete = null)
		{
		}

		public RateUsPanelMiddle()
		{
			((AutoSingletonMono<>)(object)this)._002Ector();
		}
	}
}
