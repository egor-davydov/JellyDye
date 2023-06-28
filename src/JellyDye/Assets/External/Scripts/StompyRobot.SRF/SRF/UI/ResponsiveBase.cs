using UnityEngine;

namespace SRF.UI
{
	[ExecuteInEditMode]
	public abstract class ResponsiveBase : SRMonoBehaviour
	{
		private bool _queueRefresh;

		protected RectTransform RectTransform => null;

		protected void OnEnable()
		{
		}

		protected void OnRectTransformDimensionsChange()
		{
		}

		protected void Update()
		{
		}

		protected abstract void Refresh();

		private void DoRefresh()
		{
		}
	}
}
