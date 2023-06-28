using System.Collections;
using UnityEngine;

namespace Google.Play.Common.LoadingScreen
{
	[ExecuteInEditMode]
	public class LoadingBar : MonoBehaviour
	{
		public float OutlineWidth;

		public float InnerBorderWidth;

		public bool ResizeAutomatically;

		public float Progress;

		public RectTransform Background;

		public RectTransform Outline;

		public RectTransform ProgressHolder;

		public RectTransform ProgressFill;

		public float AssetBundleDownloadToInstallRatio;

		private void Update()
		{
		}

		public void ApplyBorderWidth()
		{
		}

		public void SetProgress(float proportionOfLoadingBar)
		{
		}

		public IEnumerator FillUntilDone(AsyncOperation operation, float startingFillProportion, float endingFillProportion, bool skipFinalUpdate)
		{
			return null;
		}
	}
}
