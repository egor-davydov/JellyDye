using System;
using UnityEngine;

namespace SRF.UI
{
	[ExecuteInEditMode]
	public class ResponsiveResize : ResponsiveBase
	{
		[Serializable]
		public struct Element
		{
			[Serializable]
			public struct SizeDefinition
			{
				public float ElementWidth;

				public float ThresholdWidth;
			}

			public SizeDefinition[] SizeDefinitions;

			public RectTransform Target;
		}

		public Element[] Elements;

		protected override void Refresh()
		{
		}
	}
}
