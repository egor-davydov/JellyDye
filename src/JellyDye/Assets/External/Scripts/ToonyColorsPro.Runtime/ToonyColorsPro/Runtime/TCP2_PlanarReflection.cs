using System.Collections;
using UnityEngine;

namespace ToonyColorsPro.Runtime
{
	[ExecuteInEditMode]
	public class TCP2_PlanarReflection : MonoBehaviour
	{
		public bool m_DisablePixelLights;

		public int m_TextureSize;

		public float m_ClipPlaneOffset;

		public LayerMask m_ReflectLayers;

		private Hashtable m_ReflectionCameras;

		private RenderTexture m_ReflectionTexture;

		private int m_OldReflectionTextureSize;

		private static bool s_InsideRendering;

		public void OnWillRenderObject()
		{
		}

		private void OnDisable()
		{
		}

		private void UpdateCameraModes(Camera src, Camera dest)
		{
		}

		private void CreateMirrorObjects(Camera currentCamera, out Camera reflectionCamera)
		{
			reflectionCamera = null;
		}

		private static float sgn(float a)
		{
			return 0f;
		}

		private Vector4 CameraSpacePlane(Camera cam, Vector3 pos, Vector3 normal, float sideSign)
		{
			return default(Vector4);
		}

		private static void CalculateReflectionMatrix(ref Matrix4x4 reflectionMat, Vector4 plane)
		{
		}
	}
}
