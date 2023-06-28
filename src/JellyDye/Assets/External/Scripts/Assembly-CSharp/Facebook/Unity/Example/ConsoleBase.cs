using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Facebook.Unity.Example
{
	internal class ConsoleBase : MonoBehaviour
	{
		private const int DpiScalingFactor = 160;

		private static Stack<string> menuStack;

		private string status;

		private string lastResponse;

		private Vector2 scrollPosition;

		private float? scaleFactor;

		private GUIStyle textStyle;

		private GUIStyle buttonStyle;

		private GUIStyle textInputStyle;

		private GUIStyle labelStyle;

		protected static int ButtonHeight => 0;

		protected static int MainWindowWidth => 0;

		protected static int MainWindowFullWidth => 0;

		protected static int MarginFix => 0;

		protected static Stack<string> MenuStack
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected string Status
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected Texture2D LastResponseTexture
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		protected string LastResponse
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected Vector2 ScrollPosition
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		protected float ScaleFactor => 0f;

		protected int FontSize => 0;

		protected GUIStyle TextStyle => null;

		protected GUIStyle ButtonStyle => null;

		protected GUIStyle TextInputStyle => null;

		protected GUIStyle LabelStyle => null;

		protected virtual void Awake()
		{
		}

		protected bool Button(string label)
		{
			return false;
		}

		protected void LabelAndTextField(string label, ref string text)
		{
		}

		protected bool IsHorizontalLayout()
		{
			return false;
		}

		protected void SwitchMenu(Type menuClass)
		{
		}

		protected void GoBack()
		{
		}
	}
}
