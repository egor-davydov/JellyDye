using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Obi
{
	[CreateAssetMenu]
	[ExecuteInEditMode]
	public class ObiDistanceField : ScriptableObject
	{
		[SerializeField]
		private Mesh input;

		[HideInInspector]
		[SerializeField]
		private float minNodeSize;

		[HideInInspector]
		[SerializeField]
		private Bounds bounds;

		[HideInInspector]
		public List<DFNode> nodes;

		public float maxError;

		public int maxDepth;

		public bool Initialized => false;

		public Bounds FieldBounds => default(Bounds);

		public float EffectiveSampleSize => 0f;

		public Mesh InputMesh
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public void Reset()
		{
		}

		public IEnumerator Generate()
		{
			return null;
		}

		public Texture3D GetVolumeTexture(int size)
		{
			return null;
		}
	}
}
