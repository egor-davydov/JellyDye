using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace Coffee.UIExtensions
{
	[DisallowMultipleComponent]
	public abstract class UIEffectBase : BaseMeshEffect, IParameterTexture
	{
		protected static readonly Vector2[] splitedCharacterPosition;

		protected static readonly List<UIVertex> tempVerts;

		[HideInInspector]
		[SerializeField]
		private int m_Version;

		[SerializeField]
		protected Material m_EffectMaterial;

		public int parameterIndex
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public virtual ParameterTexture ptex => null;

		public Graphic targetGraphic => null;

		public Material effectMaterial => null;

		public virtual void ModifyMaterial()
		{
		}

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		protected virtual void SetDirty()
		{
		}

		protected override void OnDidApplyAnimationProperties()
		{
		}
	}
}
