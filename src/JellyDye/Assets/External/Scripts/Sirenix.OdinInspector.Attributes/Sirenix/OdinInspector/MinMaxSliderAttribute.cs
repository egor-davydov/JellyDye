using System;

namespace Sirenix.OdinInspector
{
	public sealed class MinMaxSliderAttribute : Attribute
	{
		public float MinValue;

		public float MaxValue;

		public string MinMember;

		public string MaxMember;

		public string MinMaxMember;

		public bool ShowFields;

		public MinMaxSliderAttribute(float minValue, float maxValue, bool showFields = false)
		{
		}

		public MinMaxSliderAttribute(string minMember, float maxValue, bool showFields = false)
		{
		}

		public MinMaxSliderAttribute(float minValue, string maxMember, bool showFields = false)
		{
		}

		public MinMaxSliderAttribute(string minMember, string maxMember, bool showFields = false)
		{
		}

		public MinMaxSliderAttribute(string minMaxMember, bool showFields = false)
		{
		}
	}
}
