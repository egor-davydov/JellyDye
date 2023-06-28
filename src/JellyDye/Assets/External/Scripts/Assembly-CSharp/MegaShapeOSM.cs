using System.Collections.Generic;
using UnityEngine;

public class MegaShapeOSM
{
	public static List<MegaShapeOSMNode> osmnodes;

	public static List<MegaShapeOSMWay> osmways;

	public static List<MegaShapeOSMTag> tags;

	private MegaShapeOSMNode FindNode(ulong id)
	{
		return null;
	}

	public void AdjustPoints(float scale)
	{
	}

	private Vector3 ConvertLatLon(Vector3 pos, Vector3 centre, float scale, bool adjust)
	{
		return default(Vector3);
	}

	public void LoadXMLTags(string sxldata)
	{
	}

	private bool CanImport(MegaShapeOSMWay way)
	{
		return false;
	}

	private string GetName(MegaShapeOSMWay way)
	{
		return null;
	}

	public void LoadXML(string sxldata, float scale, bool cspeed, string name, float smoothness, bool combine)
	{
	}

	public void ParseXML(MegaXMLNode node)
	{
	}

	public void ParseOSM(MegaXMLNode node)
	{
	}

	public void ParseNode(MegaXMLNode node)
	{
	}

	public void ParseWay(MegaXMLNode node)
	{
	}

	public void ParseND(MegaXMLNode node, MegaShapeOSMWay way)
	{
	}

	private MegaShapeOSMTag FindTagK(string val)
	{
		return null;
	}

	private MegaShapeOSMTag AddV(MegaShapeOSMTag tag, string v)
	{
		return null;
	}

	public void ParseTag(MegaXMLNode node, MegaShapeOSMWay way)
	{
	}

	public void importData(string sxldata, float scale, bool cspeed, string name, float smoothness, bool combine)
	{
	}

	public void readOSMData(string sxldata)
	{
	}
}
