using System;
using System.Collections;
using UnityEngine;

namespace GGI.Ads
{
	public class AdBase
	{
		protected Action OnAdLoaded;

		protected Action OnAdFailed;

		protected bool _autoFetch;

		protected string _adUnit;

		protected bool _isLoaded;

		protected int _retryCount;

		private Coroutine _runner;

		public AdBase(string adUnit, bool autoFetch)
		{
		}

		protected virtual void Request()
		{
		}

		private IEnumerator Backoff(float backoff)
		{
			return null;
		}

		protected void StartBackoff()
		{
		}

		protected void ResetBackoff()
		{
		}
	}
}
