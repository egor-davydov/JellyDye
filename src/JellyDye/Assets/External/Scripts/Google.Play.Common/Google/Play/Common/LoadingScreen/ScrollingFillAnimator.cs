using UnityEngine;
using UnityEngine.UI;

namespace Google.Play.Common.LoadingScreen
{
	[ExecuteInEditMode]
	public class ScrollingFillAnimator : MonoBehaviour
	{
		public float ScrollSpeed;

		private RawImage _image;

		private Vector2 _textureOffset;

		private RectTransform _rectTransform;

		private void Update()
		{
		}

		private Rect ScrollUvs(Rect uvRect)
		{
			return default(Rect);
		}

		private Rect ScaleUvs(Rect uvRect)
		{
			return default(Rect);
		}

		private void LazyInit()
		{
		}
	}
}
