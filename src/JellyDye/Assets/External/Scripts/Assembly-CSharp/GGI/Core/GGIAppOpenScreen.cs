using System.Collections;
using GGI.Components;
using TMPro;
using UnityEngine;

namespace GGI.Core
{
	public class GGIAppOpenScreen : AutoSingletonMono<GGIAppOpenScreen>
	{
		public GameObject Canvas;

		public TextMeshProUGUI LoadingText;

		private int dotsCount;

		private int maxDotsCount;

		private new void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private IEnumerator LoadingTextRoutine()
		{
			return null;
		}

		public void Show()
		{
		}

		public void Hide()
		{
		}

		public bool IsShowing()
		{
			return false;
		}

		public GGIAppOpenScreen()
		{
			((AutoSingletonMono<>)(object)this)._002Ector();
		}
	}
}
