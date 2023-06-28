using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Obi
{
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	public abstract class ObiActor : MonoBehaviour, IObiParticleCollection
	{
		public class ObiActorSolverArgs : EventArgs
		{
			public ObiSolver solver
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			public ObiActorSolverArgs(ObiSolver solver)
			{
			}
		}

		public delegate void ActorCallback(ObiActor actor);

		public delegate void ActorStepCallback(ObiActor actor, float stepTime);

		public delegate void ActorBlueprintCallback(ObiActor actor, ObiActorBlueprint blueprint);

		[NonSerialized]
		[HideInInspector]
		protected int m_ActiveParticleCount;

		[NonSerialized]
		[HideInInspector]
		public int[] solverIndices;

		[NonSerialized]
		[HideInInspector]
		public List<int>[] solverBatchOffsets;

		protected ObiSolver m_Solver;

		protected bool m_Loaded;

		private ObiActorBlueprint state;

		private ObiActorBlueprint m_BlueprintInstance;

		private ObiPinConstraintsData m_PinConstraints;

		[SerializeField]
		[HideInInspector]
		protected ObiCollisionMaterial m_CollisionMaterial;

		public ObiSolver solver => null;

		public bool isLoaded => false;

		public ObiCollisionMaterial collisionMaterial
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int particleCount => 0;

		public int activeParticleCount => 0;

		public bool usesOrientedParticles => false;

		public virtual bool usesAnisotropicParticles => false;

		public virtual bool usesCustomExternalForces => false;

		public Matrix4x4 actorLocalToSolverMatrix => default(Matrix4x4);

		public Matrix4x4 actorSolverToLocalMatrix => default(Matrix4x4);

		public abstract ObiActorBlueprint sourceBlueprint { get; }

		public ObiActorBlueprint sharedBlueprint => null;

		public ObiActorBlueprint blueprint => null;

		public event ActorBlueprintCallback OnBlueprintLoaded
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

		public event ActorBlueprintCallback OnBlueprintUnloaded
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

		public event ActorStepCallback OnBeginStep
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

		public event ActorStepCallback OnSubstep
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

		public event ActorStepCallback OnEndStep
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

		public event ActorCallback OnInterpolate
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

		protected void Awake()
		{
		}

		protected void OnDestroy()
		{
		}

		protected virtual void OnEnable()
		{
		}

		protected virtual void OnDisable()
		{
		}

		protected virtual void OnValidate()
		{
		}

		private void OnTransformParentChanged()
		{
		}

		public void AddToSolver()
		{
		}

		public void RemoveFromSolver()
		{
		}

		protected void SetSolver(ObiSolver newSolver)
		{
		}

		protected virtual void OnBlueprintRegenerate(ObiActorBlueprint blueprint)
		{
		}

		protected void UpdateCollisionMaterials()
		{
		}

		public virtual bool CopyParticle(int actorSourceIndex, int actorDestIndex)
		{
			return false;
		}

		public void TeleportParticle(int actorIndex, Vector3 position)
		{
		}

		public virtual void Teleport(Vector3 position, Quaternion rotation)
		{
		}

		protected virtual void SwapWithFirstInactiveParticle(int actorIndex)
		{
		}

		public bool ActivateParticle(int actorIndex)
		{
			return false;
		}

		public bool DeactivateParticle(int actorIndex)
		{
			return false;
		}

		public bool IsParticleActive(int actorIndex)
		{
			return false;
		}

		public virtual void SetSelfCollisions(bool selfCollisions)
		{
		}

		public void SetConstraintsDirty(Oni.ConstraintType constraintType)
		{
		}

		public IObiConstraints GetConstraintsByType(Oni.ConstraintType type)
		{
			return null;
		}

		public virtual void UpdateParticleProperties()
		{
		}

		public int GetParticleRuntimeIndex(int actorIndex)
		{
			return 0;
		}

		public Vector3 GetParticlePosition(int solverIndex)
		{
			return default(Vector3);
		}

		public Quaternion GetParticleOrientation(int solverIndex)
		{
			return default(Quaternion);
		}

		public void GetParticleAnisotropy(int solverIndex, ref Vector4 b1, ref Vector4 b2, ref Vector4 b3)
		{
		}

		public float GetParticleMaxRadius(int solverIndex)
		{
			return 0f;
		}

		public Color GetParticleColor(int solverIndex)
		{
			return default(Color);
		}

		public void SetPhase(int newPhase)
		{
		}

		public void SetMass(float mass)
		{
		}

		public float GetMass(out Vector3 com)
		{
			com = default(Vector3);
			return 0f;
		}

		public void AddForce(Vector3 force, ForceMode forceMode)
		{
		}

		public void AddTorque(Vector3 force, ForceMode forceMode)
		{
		}

		private void LoadBlueprintParticles(ObiActorBlueprint bp)
		{
		}

		private void UnloadBlueprintParticles()
		{
		}

		public void ResetParticles()
		{
		}

		public void SaveStateToBlueprint(ObiActorBlueprint bp)
		{
		}

		protected void StoreState()
		{
		}

		public void ClearState()
		{
		}

		public virtual void LoadBlueprint(ObiSolver solver)
		{
		}

		public virtual void UnloadBlueprint(ObiSolver solver)
		{
		}

		public virtual void BeginStep(float stepTime)
		{
		}

		public virtual void Substep(float substepTime)
		{
		}

		public virtual void EndStep(float substepTime)
		{
		}

		public virtual void Interpolate()
		{
		}

		public virtual void OnSolverVisibilityChanged(bool visible)
		{
		}
	}
}
