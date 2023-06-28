using UnityEngine;

public class MegaShapeSVG
{
	private int splineindex;

	private char[] commaspace;

	private const float CIRCLE_VECTOR_LENGTH = 0.5517862f;

	public void LoadXML(string svgdata, MegaShape shape, bool clear, int start)
	{
	}

	public void ParseXML(MegaXMLNode node, MegaShape shape)
	{
	}

	private MegaSpline GetSpline(MegaShape shape)
	{
		return null;
	}

	private Vector3 SwapAxis(Vector3 val, MegaAxis axis)
	{
		return default(Vector3);
	}

	private void AddKnot(MegaSpline spline, Vector3 p, Vector3 invec, Vector3 outvec, MegaAxis axis)
	{
	}

	private void ParseCircle(MegaXMLNode node, MegaShape shape)
	{
	}

	private void ParseEllipse(MegaXMLNode node, MegaShape shape)
	{
	}

	private void ParseRect(MegaXMLNode node, MegaShape shape)
	{
	}

	private void ParsePolygon(MegaXMLNode node, MegaShape shape)
	{
	}

	private void ParsePath(MegaXMLNode node, MegaShape shape)
	{
	}

	public void importData(string svgdata, MegaShape shape, float scale, bool clear, int start)
	{
	}

	private Vector2 ParseV2Split(string str, int i)
	{
		return default(Vector2);
	}

	private Vector3 ParseV2(string[] str, int i)
	{
		return default(Vector3);
	}

	public static string Export(MegaShape shape, int x, int y, float strokewidth, Color col)
	{
		return null;
	}
}
