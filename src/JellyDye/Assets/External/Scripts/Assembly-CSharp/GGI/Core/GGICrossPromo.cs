using System;
using System.Collections.Generic;
using GGI.Components;
using GGI.Data.HTTP;
using GGI.Data.Responses.CrossPromotion;

namespace GGI.Core
{
	public class GGICrossPromo : AutoSingletonMono<GGICrossPromo>
	{
		public Action OnCrossPromotionReady;

		private bool _videoInCache;

		private long _lastCacheTime;

		private GetCrossPromotionResponse _promoGame;

		private string _basePath;

		protected override void Awake()
		{
		}

		public bool IsReady()
		{
			return false;
		}

		public GetCrossPromotionResponse Game()
		{
			return null;
		}

		public string BasePath()
		{
			return null;
		}

		public void Init(string userAdvertisingId)
		{
		}

		private void OnGetCrossPromotionError(RequestError obj)
		{
		}

		private void OnGetCrossPromotionResponse(List<GetCrossPromotionResponse> data)
		{
		}

		private void OnError()
		{
		}

		private void OnVideoDownloadComplete(byte[] videoFileBytes)
		{
		}

		private void DeleteLocalData()
		{
		}

		public GGICrossPromo()
		{
			((AutoSingletonMono<>)(object)this)._002Ector();
		}
	}
}
