using UnityEngine;

namespace Facebook.Unity
{
	internal class ComponentFactory
	{
		internal enum IfNotExist
		{
			AddNew = 0,
			ReturnNull = 1
		}

		private static GameObject facebookGameObject;

		private static GameObject FacebookGameObject => null;

		public static T GetComponent<T>(IfNotExist ifNotExist = IfNotExist.AddNew) where T : MonoBehaviour
		{
			return null;
		}

		public static T AddComponent<T>() where T : MonoBehaviour
		{
			return null;
		}
	}
}
