using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Facebook.Unity
{
	internal class AsyncRequestString : MonoBehaviour
	{
		private Uri url;

		private HttpMethod method;

		private IDictionary<string, string> formData;

		private WWWForm query;

		private FacebookDelegate<IGraphResult> callback;

		internal static void Post(Uri url, Dictionary<string, string> formData = null, FacebookDelegate<IGraphResult> callback = null)
		{
		}

		internal static void Get(Uri url, Dictionary<string, string> formData = null, FacebookDelegate<IGraphResult> callback = null)
		{
		}

		internal static void Request(Uri url, HttpMethod method, WWWForm query = null, FacebookDelegate<IGraphResult> callback = null)
		{
		}

		internal static void Request(Uri url, HttpMethod method, IDictionary<string, string> formData = null, FacebookDelegate<IGraphResult> callback = null)
		{
		}

		internal IEnumerator Start()
		{
			return null;
		}

		internal AsyncRequestString SetUrl(Uri url)
		{
			return null;
		}

		internal AsyncRequestString SetMethod(HttpMethod method)
		{
			return null;
		}

		internal AsyncRequestString SetFormData(IDictionary<string, string> formData)
		{
			return null;
		}

		internal AsyncRequestString SetQuery(WWWForm query)
		{
			return null;
		}

		internal AsyncRequestString SetCallback(FacebookDelegate<IGraphResult> callback)
		{
			return null;
		}
	}
}
