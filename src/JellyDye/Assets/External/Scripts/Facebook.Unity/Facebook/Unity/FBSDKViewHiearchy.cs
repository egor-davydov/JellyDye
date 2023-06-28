using System.Collections.Generic;
using UnityEngine;

namespace Facebook.Unity
{
	public class FBSDKViewHiearchy
	{
		public static bool CheckGameObjectMatchPath(GameObject go, List<FBSDKCodelessPathComponent> path)
		{
			return false;
		}

		public static bool CheckPathMatchPath(List<FBSDKCodelessPathComponent> goPath, List<FBSDKCodelessPathComponent> path)
		{
			return false;
		}

		public static List<FBSDKCodelessPathComponent> GetPath(GameObject go)
		{
			return null;
		}

		public static List<FBSDKCodelessPathComponent> GetPath(GameObject go, int limit)
		{
			return null;
		}

		public static GameObject GetParent(GameObject go)
		{
			return null;
		}

		public static Dictionary<string, object> GetAttribute(GameObject obj, GameObject parent)
		{
			return null;
		}
	}
}
