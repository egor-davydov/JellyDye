using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Coffee.UIExtensions
{
	[ExecuteInEditMode]
	public abstract class BaseMeshEffect : UIBehaviour, IMeshModifier
	{
		private static readonly Material[] s_EmptyMaterials;

		private bool _initialized;

		private CanvasRenderer _canvasRenderer;

		private RectTransform _rectTransform;

		private Graphic _graphic;

		private Material[] _materials;

		public Graphic graphic => null;

		public CanvasRenderer canvasRenderer => null;

		public RectTransform rectTransform => null;

		public virtual AdditionalCanvasShaderChannels requiredChannels => default(AdditionalCanvasShaderChannels);

		public bool isTMPro => false;

		public virtual Material material
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public virtual Material[] materials => null;

		protected virtual bool isLegacyMeshModifier => false;

		public virtual void ModifyMesh(Mesh mesh)
		{
		}

		public virtual void ModifyMesh(VertexHelper vh)
		{
		}

		public virtual void SetVerticesDirty()
		{
		}

		public void ShowTMProWarning(Shader shader, Shader mobileShader, Shader spriteShader, Action<Material> onCreatedMaterial)
		{
		}

		protected virtual void Initialize()
		{
		}

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		protected virtual void LateUpdate()
		{
		}

		protected override void OnDidApplyAnimationProperties()
		{
		}
	}
}
