using UnityEngine;
using UnityEngine.Scripting;

namespace Firebase.Platform
{
	[Preserve]
	internal sealed class FirebaseMonoBehaviour : MonoBehaviour
	{
		private FirebaseHandler GetFirebaseHandlerOrDestroyGameObject()
		{
			return null;
		}

		[Preserve]
		private void OnEnable()
		{
		}

		[Preserve]
		private void Update()
		{
		}

		[Preserve]
		private void OnApplicationFocus(bool hasFocus)
		{
		}

		private void OnDestroy()
		{
		}
	}
}
