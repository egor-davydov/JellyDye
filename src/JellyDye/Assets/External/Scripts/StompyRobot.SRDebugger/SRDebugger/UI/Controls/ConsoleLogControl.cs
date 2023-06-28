using System;
using System.Collections;
using SRDebugger.Services;
using SRF;
using SRF.UI.Layout;
using UnityEngine;
using UnityEngine.UI;

namespace SRDebugger.UI.Controls
{
	public class ConsoleLogControl : SRMonoBehaviourEx
	{
		[RequiredField]
		[SerializeField]
		private VirtualVerticalLayoutGroup _consoleScrollLayoutGroup;

		[RequiredField]
		[SerializeField]
		private ScrollRect _consoleScrollRect;

		private bool _isDirty;

		private Vector2? _scrollPosition;

		private bool _showErrors;

		private bool _showInfo;

		private bool _showWarnings;

		public Action<ConsoleEntry> SelectedItemChanged;

		private string _filter;

		public bool ShowErrors
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool ShowWarnings
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool ShowInfo
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool EnableSelection
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public string Filter
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected override void Awake()
		{
		}

		protected override void Start()
		{
		}

		private IEnumerator ScrollToBottom()
		{
			return null;
		}

		protected override void OnDestroy()
		{
		}

		private void OnSelectedItemChanged(object arg0)
		{
		}

		protected override void Update()
		{
		}

		private void Refresh()
		{
		}

		private void SetIsDirty()
		{
		}

		private void ConsoleOnUpdated(IConsoleService console)
		{
		}
	}
}
