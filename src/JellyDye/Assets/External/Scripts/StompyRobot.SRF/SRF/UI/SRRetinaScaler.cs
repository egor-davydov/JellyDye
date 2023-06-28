using UnityEngine;

namespace SRF.UI
{
	public class SRRetinaScaler : SRMonoBehaviour
	{
		[SerializeField]
		private float _retinaScale;

		[SerializeField]
		private int _thresholdDpi;

		[SerializeField]
		private bool _disablePixelPerfect;

		public int ThresholdDpi => 0;

		public float RetinaScale => 0f;

		private void Start()
		{
		}
	}
}
