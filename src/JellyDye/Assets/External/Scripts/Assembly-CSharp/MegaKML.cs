using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MegaKML
{
	private enum kmlGeometryType
	{
		POINT = 0,
		LINESTRING = 1
	}

	private enum kmlTagType
	{
		POINT = 0,
		LINESTRING = 1,
		COORDINATES = 2
	}

	private List<Hashtable> PointsCollection;

	private List<Hashtable> LinesCollection;

	private Hashtable Point;

	private Hashtable Line;

	private Hashtable Coordinates;

	private Hashtable KMLCollection;

	private kmlGeometryType? currentGeometry;

	private kmlTagType? currentKmlTag;

	private string lastError;

	private List<Vector3> points;

	public string LastError
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Hashtable KMLDecode(string fileName)
	{
		return null;
	}

	private void readKML(string fileName)
	{
	}

	protected void parseGeometryVal(string tag_value)
	{
	}

	protected void parsePoint(string tag_value)
	{
	}

	protected void parseLine(string tag_value)
	{
	}

	public Vector3[] GetPoints(float scale)
	{
		return null;
	}

	private Vector3 ConvertLatLon(Vector3 pos, Vector3 centre, float scale, bool adjust)
	{
		return default(Vector3);
	}
}
