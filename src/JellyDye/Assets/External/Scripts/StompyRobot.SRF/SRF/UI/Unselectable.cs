using UnityEngine.EventSystems;

namespace SRF.UI
{
	public sealed class Unselectable : SRMonoBehaviour, ISelectHandler, IEventSystemHandler
	{
		private bool _suspectedSelected;

		public void OnSelect(BaseEventData eventData)
		{
		}

		private void Update()
		{
		}
	}
}
