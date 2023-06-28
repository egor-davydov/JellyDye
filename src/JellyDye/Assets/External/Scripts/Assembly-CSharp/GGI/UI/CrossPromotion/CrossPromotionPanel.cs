using System.Collections;
using GGI.Components;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

namespace GGI.UI.CrossPromotion
{
	public class CrossPromotionPanel : AutoSingletonMono<CrossPromotionPanel>
	{
		public VideoPlayer Player;

		public TextMeshProUGUI HeadlineText;

		public TextMeshProUGUI ButtonText;

		public RawImage Image;

		public GameObject CrossPromoGO;

		private string _storeUrl;

		protected override void Awake()
		{
		}

		public void Show()
		{
		}

		public void Hide()
		{
		}

		private IEnumerator Play()
		{
			return null;
		}

		public void OnPlayClick()
		{
		}

		private void PlayerOnErrorReceived(VideoPlayer source, string message)
		{
		}

		private void PlayerOnStarted(VideoPlayer source)
		{
		}

		public CrossPromotionPanel()
		{
			((AutoSingletonMono<>)(object)this)._002Ector();
		}
	}
}
