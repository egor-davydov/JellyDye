using UnityEngine;

public class BitmapData
{
	public int height;

	public int width;

	private Color[] pixels;

	public BitmapData(Color[] _pixels, int _width, int _height)
	{
	}

	public BitmapData(Texture2D texture)
	{
	}

	public Color getPixelColor(int x, int y)
	{
		return default(Color);
	}
}
