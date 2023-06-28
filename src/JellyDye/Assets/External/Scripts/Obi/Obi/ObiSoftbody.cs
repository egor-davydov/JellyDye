using UnityEngine;

namespace Obi
{
	public class ObiSoftbody : ObiActor, IShapeMatchingConstraintsUser
	{
		[SerializeField]
		protected ObiSoftbodyBlueprintBase m_SoftbodyBlueprint;

		[SerializeField]
		protected bool m_SelfCollisions;

		[SerializeField]
		[HideInInspector]
		private int centerBatch;

		[SerializeField]
		[HideInInspector]
		private int centerShape;

		[SerializeField]
		protected bool _shapeMatchingConstraintsEnabled;

		[SerializeField]
		protected float _deformationResistance;

		[SerializeField]
		protected float _maxDeformation;

		[SerializeField]
		protected float _plasticYield;

		[SerializeField]
		protected float _plasticCreep;

		[SerializeField]
		protected float _plasticRecovery;

		public bool shapeMatchingConstraintsEnabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float deformationResistance
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float maxDeformation
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float plasticYield
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float plasticCreep
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float plasticRecovery
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public override ObiActorBlueprint sourceBlueprint => null;

		public ObiSoftbodyBlueprintBase softbodyBlueprint
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool selfCollisions
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public override bool usesAnisotropicParticles => false;

		protected override void OnValidate()
		{
		}

		private void SetupRuntimeConstraints()
		{
		}

		public override void LoadBlueprint(ObiSolver solver)
		{
		}

		public override void Teleport(Vector3 position, Quaternion rotation)
		{
		}

		public void RecalculateRestShapeMatching()
		{
		}

		private void RecalculateCenterShape()
		{
		}

		public override void UpdateParticleProperties()
		{
		}

		public override void Interpolate()
		{
		}
	}
}
