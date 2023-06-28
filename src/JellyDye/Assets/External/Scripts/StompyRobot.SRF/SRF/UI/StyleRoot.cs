using UnityEngine;

namespace SRF.UI
{
	[ExecuteInEditMode]
	public sealed class StyleRoot : SRMonoBehaviour
	{
		private StyleSheet _activeStyleSheet;

		public StyleSheet StyleSheet;

		public Style GetStyle(string key)
		{
			return null;
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Update()
		{
		}

		private void OnStyleSheetChanged()
		{
		}

		public void SetDirty()
		{
		}
	}
}
