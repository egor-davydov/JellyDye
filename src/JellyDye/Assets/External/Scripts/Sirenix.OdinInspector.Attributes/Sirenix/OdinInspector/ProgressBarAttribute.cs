using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Sirenix.OdinInspector
{
	public sealed class ProgressBarAttribute : Attribute
	{
		public double Min;

		public double Max;

		public string MinMember;

		public string MaxMember;

		public float R;

		public float G;

		public float B;

		public int Height;

		public string ColorMember;

		public string BackgroundColorMember;

		public bool Segmented;

		public string CustomValueStringMember;

		private bool drawValueLabel;

		private TextAlignment valueLabelAlignment;

		public bool DrawValueLabel
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool DrawValueLabelHasValue
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public TextAlignment ValueLabelAlignment
		{
			get
			{
				return default(TextAlignment);
			}
			set
			{
			}
		}

		public bool ValueLabelAlignmentHasValue
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public ProgressBarAttribute(double min, double max, float r = 0.15f, float g = 0.47f, float b = 0.74f)
		{
		}

		public ProgressBarAttribute(string minMember, double max, float r = 0.15f, float g = 0.47f, float b = 0.74f)
		{
		}

		public ProgressBarAttribute(double min, string maxMember, float r = 0.15f, float g = 0.47f, float b = 0.74f)
		{
		}

		public ProgressBarAttribute(string minMember, string maxMember, float r = 0.15f, float g = 0.47f, float b = 0.74f)
		{
		}
	}
}
