using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace GGI.UI.IDFAOptin
{
	public class IDFAOptinPopupType4 : MonoBehaviour
	{
		public CanvasGroup CanvasGroup;

		public Image GameIconImage;

		public TextMeshProUGUI TitleText;

		public TextMeshProUGUI DescText;

		public TextMeshProUGUI OptionYes;

		public TextMeshProUGUI OptionNo;

		public Button XButton;

		private bool _hasTransitioned;

		private bool _hasXButton;

		private float _xButtonTimer;

		private long _xButtonWaitSeconds;

		private bool _xButtonTimerRunOut;

		private Vector3 _initialIconPos;

		private Vector3 _initialTextPos;

		private void Awake()
		{
		}

		private void Update()
		{
		}

		public void OnOptionYes()
		{
		}

		public void OnOptionNo()
		{
		}

		public void Refresh()
		{
		}

		private void SetTexts()
		{
		}
	}
}
