using System.Collections;
using UnityEngine;

namespace Facebook.Unity.Example
{
	internal class GraphRequest : MenuBase
	{
		private string apiQuery;

		private Texture2D profilePic;

		protected override void GetGui()
		{
		}

		private void ProfilePhotoCallback(IGraphResult result)
		{
		}

		private IEnumerator TakeScreenshot()
		{
			return null;
		}
	}
}
