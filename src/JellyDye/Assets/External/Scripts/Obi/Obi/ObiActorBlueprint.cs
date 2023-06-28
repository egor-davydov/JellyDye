using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Obi
{
	public abstract class ObiActorBlueprint : ScriptableObject, IObiParticleCollection
	{
		public delegate void BlueprintCallback(ObiActorBlueprint blueprint);

		[HideInInspector]
		[SerializeField]
		protected bool m_Empty;

		[HideInInspector]
		[SerializeField]
		protected int m_ActiveParticleCount;

		[HideInInspector]
		[SerializeField]
		protected int m_InitialActiveParticleCount;

		[HideInInspector]
		[SerializeField]
		protected Bounds _bounds;

		[HideInInspector]
		public Vector3[] positions;

		[HideInInspector]
		public Vector4[] restPositions;

		[HideInInspector]
		public Quaternion[] orientations;

		[HideInInspector]
		public Quaternion[] restOrientations;

		[HideInInspector]
		public Vector3[] velocities;

		[HideInInspector]
		public Vector3[] angularVelocities;

		[HideInInspector]
		public float[] invMasses;

		[HideInInspector]
		public float[] invRotationalMasses;

		[HideInInspector]
		public int[] phases;

		[HideInInspector]
		public Vector3[] principalRadii;

		[HideInInspector]
		public Color[] colors;

		[HideInInspector]
		public ObiDistanceConstraintsData distanceConstraintsData;

		[HideInInspector]
		public ObiBendConstraintsData bendConstraintsData;

		[HideInInspector]
		public ObiSkinConstraintsData skinConstraintsData;

		[HideInInspector]
		public ObiTetherConstraintsData tetherConstraintsData;

		[HideInInspector]
		public ObiStretchShearConstraintsData stretchShearConstraintsData;

		[HideInInspector]
		public ObiBendTwistConstraintsData bendTwistConstraintsData;

		[HideInInspector]
		public ObiShapeMatchingConstraintsData shapeMatchingConstraintsData;

		[HideInInspector]
		public ObiAerodynamicConstraintsData aerodynamicConstraintsData;

		[HideInInspector]
		public ObiChainConstraintsData chainConstraintsData;

		[HideInInspector]
		public ObiVolumeConstraintsData volumeConstraintsData;

		[HideInInspector]
		public List<ObiParticleGroup> groups;

		public int particleCount => 0;

		public int activeParticleCount => 0;

		public bool usesOrientedParticles => false;

		public virtual bool usesTethers => false;

		public bool empty => false;

		public Bounds bounds => default(Bounds);

		public event BlueprintCallback OnBlueprintGenerate
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public bool IsParticleActive(int index)
		{
			return false;
		}

		protected virtual void SwapWithFirstInactiveParticle(int index)
		{
		}

		public bool ActivateParticle(int index)
		{
			return false;
		}

		public bool DeactivateParticle(int index)
		{
			return false;
		}

		public void RecalculateBounds()
		{
		}

		public IEnumerable<IObiConstraints> GetConstraints()
		{
			return null;
		}

		public IObiConstraints GetConstraintsByType(Oni.ConstraintType type)
		{
			return null;
		}

		public int GetParticleRuntimeIndex(int blueprintIndex)
		{
			return 0;
		}

		public Vector3 GetParticlePosition(int index)
		{
			return default(Vector3);
		}

		public Quaternion GetParticleOrientation(int index)
		{
			return default(Quaternion);
		}

		public void GetParticleAnisotropy(int index, ref Vector4 b1, ref Vector4 b2, ref Vector4 b3)
		{
		}

		public float GetParticleMaxRadius(int index)
		{
			return 0f;
		}

		public Color GetParticleColor(int index)
		{
			return default(Color);
		}

		public void GenerateImmediate()
		{
		}

		public IEnumerator Generate()
		{
			return null;
		}

		public ObiParticleGroup InsertNewParticleGroup(string name, int index)
		{
			return null;
		}

		public ObiParticleGroup AppendNewParticleGroup(string name)
		{
			return null;
		}

		public bool RemoveParticleGroupAt(int index)
		{
			return false;
		}

		public bool SetParticleGroupName(int index, string name)
		{
			return false;
		}

		public void ClearParticleGroups()
		{
		}

		private bool IsParticleSharedInConstraint(int index, List<int> particles, bool[] selected)
		{
			return false;
		}

		private bool DoesParticleShareConstraints(IObiConstraints constraints, int index, List<int> particles, bool[] selected)
		{
			return false;
		}

		private void DeactivateConstraintsWithInactiveParticles(IObiConstraints constraints, List<int> particles)
		{
		}

		private void ParticlesSwappedInGroups(int index, int newIndex)
		{
		}

		public void RemoveSelectedParticles(ref bool[] selected, bool optimize = true)
		{
		}

		public void RestoreRemovedParticles()
		{
		}

		public virtual void GenerateTethers(bool[] selected)
		{
		}

		public virtual void ClearTethers()
		{
		}

		protected abstract IEnumerator Initialize();
	}
}
