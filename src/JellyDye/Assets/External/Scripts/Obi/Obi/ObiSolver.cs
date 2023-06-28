using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Profiling;
using UnityEngine;

namespace Obi
{
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	public sealed class ObiSolver : MonoBehaviour
	{
		public enum BackendType
		{
			Oni = 0,
			Burst = 1
		}

		public class ObiCollisionEventArgs : EventArgs
		{
			public ObiList<Oni.Contact> contacts;
		}

		[Serializable]
		public class ParticleInActor
		{
			public ObiActor actor;

			public int indexInActor;

			public ParticleInActor()
			{
			}

			public ParticleInActor(ObiActor actor, int indexInActor)
			{
			}
		}

		public delegate void SolverCallback(ObiSolver solver);

		public delegate void SolverStepCallback(ObiSolver solver, float stepTime);

		public delegate void CollisionCallback(ObiSolver solver, ObiCollisionEventArgs contacts);

		private static ProfilerMarker m_StateInterpolationPerfMarker;

		private static ProfilerMarker m_UpdateVisibilityPerfMarker;

		private static ProfilerMarker m_GetSolverBoundsPerfMarker;

		private static ProfilerMarker m_TestBoundsPerfMarker;

		private static ProfilerMarker m_GetAllCamerasPerfMarker;

		public bool simulateWhenInvisible;

		private ISolverImpl m_SolverImpl;

		private IObiBackend m_SimulationBackend;

		[SerializeField]
		private BackendType m_Backend;

		[ChildrenOnly]
		public Oni.SolverParameters parameters;

		public float worldLinearInertiaScale;

		public float worldAngularInertiaScale;

		[NonSerialized]
		[HideInInspector]
		public List<ObiActor> actors;

		[NonSerialized]
		[HideInInspector]
		public ParticleInActor[] m_ParticleToActor;

		private ObiNativeIntList freeList;

		private int[] activeParticles;

		private int activeParticleCount;

		[NonSerialized]
		[HideInInspector]
		public bool dirtyActiveParticles;

		[NonSerialized]
		[HideInInspector]
		public int dirtyConstraints;

		private ObiCollisionEventArgs collisionArgs;

		private ObiCollisionEventArgs particleCollisionArgs;

		private float m_MaxScale;

		private Bounds bounds;

		private Plane[] planes;

		private Camera[] sceneCameras;

		private bool isVisible;

		[NonSerialized]
		private IObiConstraints[] m_Constraints;

		public Oni.ConstraintParameters distanceConstraintParameters;

		public Oni.ConstraintParameters bendingConstraintParameters;

		public Oni.ConstraintParameters particleCollisionConstraintParameters;

		public Oni.ConstraintParameters particleFrictionConstraintParameters;

		public Oni.ConstraintParameters collisionConstraintParameters;

		public Oni.ConstraintParameters frictionConstraintParameters;

		public Oni.ConstraintParameters skinConstraintParameters;

		public Oni.ConstraintParameters volumeConstraintParameters;

		public Oni.ConstraintParameters shapeMatchingConstraintParameters;

		public Oni.ConstraintParameters tetherConstraintParameters;

		public Oni.ConstraintParameters pinConstraintParameters;

		public Oni.ConstraintParameters stitchConstraintParameters;

		public Oni.ConstraintParameters densityConstraintParameters;

		public Oni.ConstraintParameters stretchShearConstraintParameters;

		public Oni.ConstraintParameters bendTwistConstraintParameters;

		public Oni.ConstraintParameters chainConstraintParameters;

		private ObiNativeVector4List m_RigidbodyLinearVelocities;

		private ObiNativeVector4List m_RigidbodyAngularVelocities;

		[NonSerialized]
		private Color[] m_Colors;

		[NonSerialized]
		private ObiNativeInt4List m_CellCoords;

		[NonSerialized]
		private ObiNativeVector4List m_Positions;

		[NonSerialized]
		private ObiNativeVector4List m_RestPositions;

		[NonSerialized]
		private ObiNativeVector4List m_PrevPositions;

		[NonSerialized]
		private ObiNativeVector4List m_StartPositions;

		[NonSerialized]
		private ObiNativeVector4List m_RenderablePositions;

		[NonSerialized]
		private ObiNativeQuaternionList m_Orientations;

		[NonSerialized]
		private ObiNativeQuaternionList m_RestOrientations;

		[NonSerialized]
		private ObiNativeQuaternionList m_PrevOrientations;

		[NonSerialized]
		private ObiNativeQuaternionList m_StartOrientations;

		[NonSerialized]
		private ObiNativeQuaternionList m_RenderableOrientations;

		[NonSerialized]
		private ObiNativeVector4List m_Velocities;

		[NonSerialized]
		private ObiNativeVector4List m_AngularVelocities;

		[NonSerialized]
		private ObiNativeFloatList m_InvMasses;

		[NonSerialized]
		private ObiNativeFloatList m_InvRotationalMasses;

		[NonSerialized]
		private ObiNativeVector4List m_InvInertiaTensors;

		[NonSerialized]
		private ObiNativeVector4List m_ExternalForces;

		[NonSerialized]
		private ObiNativeVector4List m_ExternalTorques;

		[NonSerialized]
		private ObiNativeVector4List m_Wind;

		[NonSerialized]
		private ObiNativeVector4List m_PositionDeltas;

		[NonSerialized]
		private ObiNativeQuaternionList m_OrientationDeltas;

		[NonSerialized]
		private ObiNativeIntList m_PositionConstraintCounts;

		[NonSerialized]
		private ObiNativeIntList m_OrientationConstraintCounts;

		[NonSerialized]
		private ObiNativeIntList m_CollisionMaterials;

		[NonSerialized]
		private ObiNativeIntList m_Phases;

		[NonSerialized]
		private ObiNativeVector4List m_Anisotropies;

		[NonSerialized]
		private ObiNativeVector4List m_PrincipalRadii;

		[NonSerialized]
		private ObiNativeVector4List m_Normals;

		[NonSerialized]
		private ObiNativeVector4List m_Vorticities;

		[NonSerialized]
		private ObiNativeVector4List m_FluidData;

		[NonSerialized]
		private ObiNativeVector4List m_UserData;

		[NonSerialized]
		private ObiNativeFloatList m_SmoothingRadii;

		[NonSerialized]
		private ObiNativeFloatList m_Buoyancies;

		[NonSerialized]
		private ObiNativeFloatList m_RestDensities;

		[NonSerialized]
		private ObiNativeFloatList m_Viscosities;

		[NonSerialized]
		private ObiNativeFloatList m_SurfaceTension;

		[NonSerialized]
		private ObiNativeFloatList m_VortConfinement;

		[NonSerialized]
		private ObiNativeFloatList m_AtmosphericDrag;

		[NonSerialized]
		private ObiNativeFloatList m_AtmosphericPressure;

		[NonSerialized]
		private ObiNativeFloatList m_Diffusion;

		public ISolverImpl implementation => null;

		public bool initialized => false;

		public IObiBackend simulationBackend => null;

		public BackendType backendType
		{
			get
			{
				return default(BackendType);
			}
			set
			{
			}
		}

		public Bounds Bounds => default(Bounds);

		public bool IsVisible => false;

		public float maxScale => 0f;

		public int AllocParticleCount => 0;

		public ParticleInActor[] particleToActor => null;

		public ObiNativeVector4List rigidbodyLinearDeltas => null;

		public ObiNativeVector4List rigidbodyAngularDeltas => null;

		public Color[] colors => null;

		public ObiNativeInt4List cellCoords => null;

		public ObiNativeVector4List positions => null;

		public ObiNativeVector4List restPositions => null;

		public ObiNativeVector4List prevPositions => null;

		public ObiNativeVector4List startPositions => null;

		public ObiNativeVector4List renderablePositions => null;

		public ObiNativeQuaternionList orientations => null;

		public ObiNativeQuaternionList restOrientations => null;

		public ObiNativeQuaternionList prevOrientations => null;

		public ObiNativeQuaternionList startOrientations => null;

		public ObiNativeQuaternionList renderableOrientations => null;

		public ObiNativeVector4List velocities => null;

		public ObiNativeVector4List angularVelocities => null;

		public ObiNativeFloatList invMasses => null;

		public ObiNativeFloatList invRotationalMasses => null;

		public ObiNativeVector4List invInertiaTensors => null;

		public ObiNativeVector4List externalForces => null;

		public ObiNativeVector4List externalTorques => null;

		public ObiNativeVector4List wind => null;

		public ObiNativeVector4List positionDeltas => null;

		public ObiNativeQuaternionList orientationDeltas => null;

		public ObiNativeIntList positionConstraintCounts => null;

		public ObiNativeIntList orientationConstraintCounts => null;

		public ObiNativeIntList collisionMaterials => null;

		public ObiNativeIntList phases => null;

		public ObiNativeVector4List anisotropies => null;

		public ObiNativeVector4List principalRadii => null;

		public ObiNativeVector4List normals => null;

		public ObiNativeVector4List vorticities => null;

		public ObiNativeVector4List fluidData => null;

		public ObiNativeVector4List userData => null;

		public ObiNativeFloatList smoothingRadii => null;

		public ObiNativeFloatList buoyancies => null;

		public ObiNativeFloatList restDensities => null;

		public ObiNativeFloatList viscosities => null;

		public ObiNativeFloatList surfaceTension => null;

		public ObiNativeFloatList vortConfinement => null;

		public ObiNativeFloatList atmosphericDrag => null;

		public ObiNativeFloatList atmosphericPressure => null;

		public ObiNativeFloatList diffusion => null;

		public event CollisionCallback OnCollision
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

		public event CollisionCallback OnParticleCollision
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

		public event SolverCallback OnUpdateParameters
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

		public event SolverStepCallback OnBeginStep
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

		public event SolverStepCallback OnSubstep
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

		public event SolverCallback OnEndStep
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

		public event SolverCallback OnInterpolate
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

		private void Update()
		{
		}

		private void OnDestroy()
		{
		}

		private void CreateBackend()
		{
		}

		public void Initialize()
		{
		}

		public void Teardown()
		{
		}

		public void UpdateBackend()
		{
		}

		private void FreeRigidbodyArrays()
		{
		}

		public void EnsureRigidbodyArraysCapacity(int count)
		{
		}

		private void FreeParticleArrays()
		{
		}

		private void EnsureParticleArraysCapacity(int count)
		{
		}

		private void AllocateParticles(int[] particleIndices)
		{
		}

		private void FreeParticles(int[] particleIndices)
		{
		}

		public bool AddActor(ObiActor actor)
		{
			return false;
		}

		public bool RemoveActor(ObiActor actor)
		{
			return false;
		}

		public void PushSolverParameters()
		{
		}

		public Oni.ConstraintParameters GetConstraintParameters(Oni.ConstraintType constraintType)
		{
			return default(Oni.ConstraintParameters);
		}

		public IObiConstraints GetConstraintsByType(Oni.ConstraintType type)
		{
			return null;
		}

		private void PushActiveParticles()
		{
		}

		private void PushConstraints()
		{
		}

		private void UpdateVisibility()
		{
		}

		private void InitializeTransformFrame()
		{
		}

		private void UpdateTransformFrame(float dt)
		{
		}

		public IObiJobHandle BeginStep(float stepTime)
		{
			return null;
		}

		public IObiJobHandle Substep(float substepTime)
		{
			return null;
		}

		public void EndStep(float substepTime)
		{
		}

		public void Interpolate(float stepTime, float unsimulatedTime)
		{
		}
	}
}
