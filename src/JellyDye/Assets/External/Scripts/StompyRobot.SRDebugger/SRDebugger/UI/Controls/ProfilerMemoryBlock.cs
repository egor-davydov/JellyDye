using System.Collections;
using SRF;
using UnityEngine.UI;

namespace SRDebugger.UI.Controls
{
	public class ProfilerMemoryBlock : SRMonoBehaviourEx
	{
		private float _lastRefresh;

		[RequiredField]
		public Text CurrentUsedText;

		[RequiredField]
		public Slider Slider;

		[RequiredField]
		public Text TotalAllocatedText;

		protected override void OnEnable()
		{
		}

		protected override void Update()
		{
		}

		public void TriggerRefresh()
		{
		}

		public void TriggerCleanup()
		{
		}

		private IEnumerator CleanUp()
		{
			return null;
		}
	}
}
