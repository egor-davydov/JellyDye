using UnityEngine;

namespace Obi
{
	[ExecuteInEditMode]
	public class ObiDistanceFieldRenderer : MonoBehaviour
	{
		public enum Axis
		{
			X = 0,
			Y = 1,
			Z = 2
		}

		public Axis axis;

		public float slice;

		public float maxDistance;

		private ObiCollider unityCollider;

		private Material material;

		private Mesh planeMesh;

		private Texture2D cutawayTexture;

		private float sampleSize;

		private int sampleCount;

		private Color boundsColor;

		public void Awake()
		{
		}

		public void OnEnable()
		{
		}

		public void OnDisable()
		{
		}

		private void Cleanup()
		{
		}

		private void ResizeTexture()
		{
		}

		private void CreatePlaneMesh(ObiDistanceField field)
		{
		}

		private void RefreshCutawayTexture(ObiDistanceField field)
		{
		}

		private void DrawCutawayPlane(ObiDistanceField field, Matrix4x4 matrix)
		{
		}

		public void OnDrawGizmos()
		{
		}
	}
}
