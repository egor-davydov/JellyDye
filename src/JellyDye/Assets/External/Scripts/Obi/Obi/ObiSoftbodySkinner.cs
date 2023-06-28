using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Obi
{
	[ExecuteInEditMode]
	public class ObiSoftbodySkinner : MonoBehaviour
	{
		public float m_SkinningFalloff;

		public float m_SkinningMaxDistance;

		[HideInInspector]
		[SerializeField]
		private List<Matrix4x4> m_Bindposes;

		[HideInInspector]
		[SerializeField]
		private BoneWeight[] m_BoneWeights;

		private SkinnedMeshRenderer m_Target;

		private Mesh m_SoftMesh;

		private List<Transform> m_Bones;

		[HideInInspector]
		[SerializeField]
		public bool m_Bound;

		[SerializeField]
		[HideInInspector]
		private ObiSoftbody m_Source;

		public ObiSoftbody Source
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public void Awake()
		{
		}

		public void OnDestroy()
		{
		}

		private void CreateBones()
		{
		}

		private void DestroyBones()
		{
		}

		private void UpdateBones(ObiActor actor)
		{
		}

		public IEnumerator BindSkin()
		{
			return null;
		}

		private BoneWeight CalculateBoneWeights(Vector3 vertex, List<Vector3> clusterCenters)
		{
			return default(BoneWeight);
		}

		private void NormalizeBoneWeight(ref BoneWeight w)
		{
		}

		private void AppendBindposes()
		{
		}

		private void AppendBoneWeights()
		{
		}

		private void AppendBoneTransforms()
		{
		}

		private void CopyBoneTransforms()
		{
		}
	}
}
