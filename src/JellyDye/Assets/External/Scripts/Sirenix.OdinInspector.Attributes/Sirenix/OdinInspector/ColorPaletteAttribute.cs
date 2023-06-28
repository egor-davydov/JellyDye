using System;

namespace Sirenix.OdinInspector
{
	public sealed class ColorPaletteAttribute : Attribute
	{
		public string PaletteName;

		public bool ShowAlpha;

		public ColorPaletteAttribute()
		{
		}

		public ColorPaletteAttribute(string paletteName)
		{
		}
	}
}
