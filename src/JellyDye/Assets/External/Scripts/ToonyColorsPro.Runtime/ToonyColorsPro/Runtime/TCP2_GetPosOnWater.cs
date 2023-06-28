using UnityEngine;

namespace ToonyColorsPro.Runtime
{
	public class TCP2_GetPosOnWater : MonoBehaviour
	{
		public Material WaterMaterial;

		public float heightScale;

		[Space]
		public bool followWaterHeight;

		public float heightOffset;

		[Space]
		public bool followWaterNormal;

		public Vector3 upAxis;

		public Vector3 postRotation;

		[SerializeField]
		[HideInInspector]
		private bool isValid;

		[SerializeField]
		[HideInInspector]
		private int sineCount;

		private float[] sinePosOffsetsX;

		private float[] sinePosOffsetsZ;

		private float[] sinePhsOffsetsX;

		private float[] sinePhsOffsetsZ;

		private void LateUpdate()
		{
		}

		public Vector3 GetPositionOnWater(Vector3 worldPosition)
		{
			return default(Vector3);
		}

		public Vector3 GetNormalOnWater(Vector3 worldPosition)
		{
			return default(Vector3);
		}
	}
}
