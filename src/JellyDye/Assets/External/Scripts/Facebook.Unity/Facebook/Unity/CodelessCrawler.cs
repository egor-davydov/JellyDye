using System.Collections;
using System.Text;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Facebook.Unity
{
	public class CodelessCrawler : MonoBehaviour
	{
		private static bool isGeneratingSnapshot;

		private static Camera mainCamera;

		public void Awake()
		{
		}

		public void CaptureViewHierarchy(string message)
		{
		}

		private IEnumerator GenSnapshot()
		{
			return null;
		}

		private static void SendAndroid(string json)
		{
		}

		private static void SendIos(string json)
		{
		}

		private static string GenBase64Screenshot()
		{
			return null;
		}

		private static string GenViewJson()
		{
			return null;
		}

		private static void GenChild(GameObject curObj, StringBuilder builder)
		{
		}

		private void onActiveSceneChanged(Scene arg0, Scene arg1)
		{
		}

		private static void updateMainCamera()
		{
		}

		private static Vector2 getScreenCoordinate(Vector3 position, RenderMode renderMode)
		{
			return default(Vector2);
		}

		private static string getClasstypeBitmaskButton()
		{
			return null;
		}

		private static string getVisibility(GameObject gameObj)
		{
			return null;
		}
	}
}
