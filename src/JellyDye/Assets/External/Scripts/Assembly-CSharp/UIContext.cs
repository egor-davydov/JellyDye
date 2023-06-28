using System.Collections.Generic;

public static class UIContext
{
	private static List<UIElement> elements;

	public static void UpdateElements()
	{
	}

	public static T GetElement<T>() where T : UIElement
	{
		return null;
	}

	public static List<T> GetElements<T>() where T : UIElement
	{
		return null;
	}

	public static List<UIElement> GetAll()
	{
		return null;
	}
}
