using UnityEngine;

namespace Obi
{
	public class InspectorButtonAttribute : PropertyAttribute
	{
		public static float kDefaultButtonWidth;

		public readonly string MethodName;

		private float _buttonWidth;

		public float ButtonWidth
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public InspectorButtonAttribute(string MethodName)
		{
		}
	}
}
