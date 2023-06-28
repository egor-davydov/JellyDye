using SRDebugger.UI.Controls;
using SRF;
using SRF.UI;
using UnityEngine;

namespace SRDebugger.UI.Other
{
	public class TriggerRoot : SRMonoBehaviourEx
	{
		[RequiredField]
		public Canvas Canvas;

		[RequiredField]
		public LongPressButton TapHoldButton;

		[RequiredField]
		public RectTransform TriggerTransform;

		[RequiredField]
		public ErrorNotifier ErrorNotifier;

		[RequiredField]
		public MultiTapButton TripleTapButton;
	}
}
