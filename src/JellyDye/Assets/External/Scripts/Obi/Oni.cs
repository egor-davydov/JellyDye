using System;
using System.Runtime.InteropServices;
using UnityEngine;

public static class Oni
{
	public enum ConstraintType
	{
		Tether = 0,
		Volume = 1,
		Chain = 2,
		Bending = 3,
		Distance = 4,
		ShapeMatching = 5,
		BendTwist = 6,
		StretchShear = 7,
		Pin = 8,
		ParticleCollision = 9,
		Density = 10,
		Collision = 11,
		Skin = 12,
		Aerodynamics = 13,
		Stitch = 14,
		ParticleFriction = 15,
		Friction = 16
	}

	[Flags]
	public enum ParticleFlags
	{
		GroupMask = 0xFFFFFF,
		SelfCollide = 0x1000000,
		Fluid = 0x2000000,
		OneSided = 0x4000000
	}

	public enum ShapeType
	{
		Sphere = 0,
		Box = 1,
		Capsule = 2,
		Heightmap = 3,
		TriangleMesh = 4,
		EdgeMesh = 5,
		SignedDistanceField = 6
	}

	public enum MaterialCombineMode
	{
		Average = 0,
		Minimum = 1,
		Multiply = 2,
		Maximum = 3
	}

	public enum ProfileMask : uint
	{
		ThreadIdMask = 4294901760u,
		TypeMask = 255u,
		StackLevelMask = 65280u
	}

	public struct ProfileInfo
	{
		public double start;

		public double end;

		public uint info;

		public int pad;

		public string name;
	}

	public struct GridCell
	{
		public Vector3 center;

		public Vector3 size;

		public int count;
	}

	[Serializable]
	public struct SolverParameters
	{
		public enum Interpolation
		{
			None = 0,
			Interpolate = 1
		}

		public enum Mode
		{
			Mode3D = 0,
			Mode2D = 1
		}

		public Mode mode;

		public Interpolation interpolation;

		public Vector3 gravity;

		public float damping;

		public float shockPropagation;

		public float maxAnisotropy;

		public float maxDepenetration;

		public float sleepThreshold;

		public SolverParameters(Interpolation interpolation, Vector4 gravity)
		{
		}
	}

	[Serializable]
	public struct ConstraintParameters
	{
		public enum EvaluationOrder
		{
			Sequential = 0,
			Parallel = 1
		}

		public EvaluationOrder evaluationOrder;

		public int iterations;

		public float SORFactor;

		public bool enabled;

		public ConstraintParameters(bool enabled, EvaluationOrder order, int iterations)
		{
		}
	}

	[StructLayout(0, Size = 128)]
	public struct Contact
	{
		public Vector4 point;

		public Vector4 normal;

		public Vector4 tangent;

		public Vector4 bitangent;

		public float distance;

		public float normalImpulse;

		public float tangentImpulse;

		public float bitangentImpulse;

		public float stickImpulse;

		public float rollingFrictionImpulse;

		public int particle;

		public int other;
	}

	public const int ConstraintTypeCount = 17;

	private const string LIBNAME = "Oni";

	public static GCHandle PinMemory(object data)
	{
		return default(GCHandle);
	}

	public static void UnpinMemory(GCHandle handle)
	{
	}

	[PreserveSig]
	public static extern void UpdateColliderGrid();

	[PreserveSig]
	public static extern void SetColliders(IntPtr shapes, IntPtr bounds, IntPtr transforms, int count);

	[PreserveSig]
	public static extern void SetRigidbodies(IntPtr rigidbodies);

	[PreserveSig]
	public static extern void SetCollisionMaterials(IntPtr materials);

	[PreserveSig]
	public static extern void SetTriangleMeshData(IntPtr headers, IntPtr nodes, IntPtr triangles, IntPtr vertices);

	[PreserveSig]
	public static extern void SetEdgeMeshData(IntPtr headers, IntPtr nodes, IntPtr edges, IntPtr vertices);

	[PreserveSig]
	public static extern void SetDistanceFieldData(IntPtr headers, IntPtr nodes);

	[PreserveSig]
	public static extern void SetHeightFieldData(IntPtr headers, IntPtr samples);

	[PreserveSig]
	public static extern IntPtr CreateSolver(int capacity);

	[PreserveSig]
	public static extern void DestroySolver(IntPtr solver);

	[PreserveSig]
	public static extern void SetCapacity(IntPtr solver, int capacity);

	[PreserveSig]
	public static extern void InitializeFrame(IntPtr solver, ref Vector4 translation, ref Vector4 scale, ref Quaternion rotation);

	[PreserveSig]
	public static extern void UpdateFrame(IntPtr solver, ref Vector4 translation, ref Vector4 scale, ref Quaternion rotation, float dt);

	[PreserveSig]
	public static extern void ApplyFrame(IntPtr solver, float linearVelocityScale, float angularVelocityScale, float linearInertiaScale, float angularInertiaScale, float dt);

	[PreserveSig]
	public static extern void RecalculateInertiaTensors(IntPtr solver);

	[PreserveSig]
	public static extern void ResetForces(IntPtr solver);

	[PreserveSig]
	public static extern void SetRigidbodyLinearDeltas(IntPtr solver, IntPtr linearDeltas);

	[PreserveSig]
	public static extern void SetRigidbodyAngularDeltas(IntPtr solver, IntPtr angularDeltas);

	[PreserveSig]
	public static extern void GetBounds(IntPtr solver, ref Vector3 min, ref Vector3 max);

	[PreserveSig]
	public static extern int GetParticleGridSize(IntPtr solver);

	[PreserveSig]
	public static extern void GetParticleGrid(IntPtr solver, GridCell[] cells);

	[PreserveSig]
	public static extern void SetSolverParameters(IntPtr solver, ref SolverParameters parameters);

	[PreserveSig]
	public static extern void GetSolverParameters(IntPtr solver, ref SolverParameters parameters);

	[PreserveSig]
	public static extern int SetActiveParticles(IntPtr solver, int[] active, int num);

	[PreserveSig]
	public static extern IntPtr CollisionDetection(IntPtr solver, float delta_time);

	[PreserveSig]
	public static extern IntPtr Step(IntPtr solver, float delta_time);

	[PreserveSig]
	public static extern void ApplyPositionInterpolation(IntPtr solver, IntPtr draw_positions, IntPtr draw_orientations, float delta_seconds, float unsimulated_time);

	[PreserveSig]
	public static extern void UpdateSkeletalAnimation(IntPtr solver);

	[PreserveSig]
	public static extern int GetConstraintCount(IntPtr solver, int type);

	[PreserveSig]
	public static extern void SetRenderableParticlePositions(IntPtr solver, IntPtr positions);

	[PreserveSig]
	public static extern void SetParticlePhases(IntPtr solver, IntPtr phases);

	[PreserveSig]
	public static extern void SetParticleCollisionMaterials(IntPtr solver, IntPtr materialIndices);

	[PreserveSig]
	public static extern void SetParticlePositions(IntPtr solver, IntPtr positions);

	[PreserveSig]
	public static extern void SetParticlePreviousPositions(IntPtr solver, IntPtr prevPositions);

	[PreserveSig]
	public static extern void SetParticleOrientations(IntPtr solver, IntPtr orientations);

	[PreserveSig]
	public static extern void SetParticlePreviousOrientations(IntPtr solver, IntPtr prevOrientations);

	[PreserveSig]
	public static extern void SetRenderableParticleOrientations(IntPtr solver, IntPtr orientations);

	[PreserveSig]
	public static extern void SetParticleInverseMasses(IntPtr solver, IntPtr invMasses);

	[PreserveSig]
	public static extern void SetParticleInverseRotationalMasses(IntPtr solver, IntPtr invRotMasses);

	[PreserveSig]
	public static extern void SetParticlePrincipalRadii(IntPtr solver, IntPtr principalRadii);

	[PreserveSig]
	public static extern void SetParticleVelocities(IntPtr solver, IntPtr velocities);

	[PreserveSig]
	public static extern void SetParticleAngularVelocities(IntPtr solver, IntPtr angularVelocities);

	[PreserveSig]
	public static extern void SetParticleExternalForces(IntPtr solver, IntPtr forces);

	[PreserveSig]
	public static extern void SetParticleExternalTorques(IntPtr solver, IntPtr torques);

	[PreserveSig]
	public static extern void SetParticleWinds(IntPtr solver, IntPtr winds);

	[PreserveSig]
	public static extern void SetParticlePositionDeltas(IntPtr solver, IntPtr deltas);

	[PreserveSig]
	public static extern void SetParticleOrientationDeltas(IntPtr solver, IntPtr deltas);

	[PreserveSig]
	public static extern void SetParticlePositionConstraintCounts(IntPtr solver, IntPtr counts);

	[PreserveSig]
	public static extern void SetParticleOrientationConstraintCounts(IntPtr solver, IntPtr counts);

	[PreserveSig]
	public static extern void SetParticleNormals(IntPtr solver, IntPtr normals);

	[PreserveSig]
	public static extern void SetParticleInverseInertiaTensors(IntPtr solver, IntPtr tensors);

	[PreserveSig]
	public static extern void SetParticleSmoothingRadii(IntPtr solver, IntPtr radii);

	[PreserveSig]
	public static extern void SetParticleBuoyancy(IntPtr solver, IntPtr buoyancy);

	[PreserveSig]
	public static extern void SetParticleRestDensities(IntPtr solver, IntPtr rest_densities);

	[PreserveSig]
	public static extern void SetParticleViscosities(IntPtr solver, IntPtr viscosities);

	[PreserveSig]
	public static extern void SetParticleSurfaceTension(IntPtr solver, IntPtr surface_tension);

	[PreserveSig]
	public static extern void SetParticleVorticityConfinement(IntPtr solver, IntPtr vort_confinement);

	[PreserveSig]
	public static extern void SetParticleAtmosphericDragPressure(IntPtr solver, IntPtr atmospheric_drag, IntPtr atmospheric_pressure);

	[PreserveSig]
	public static extern void SetParticleDiffusion(IntPtr solver, IntPtr diffusion);

	[PreserveSig]
	public static extern void SetParticleVorticities(IntPtr solver, IntPtr vorticities);

	[PreserveSig]
	public static extern void SetParticleFluidData(IntPtr solver, IntPtr fluidData);

	[PreserveSig]
	public static extern void SetParticleUserData(IntPtr solver, IntPtr userData);

	[PreserveSig]
	public static extern void SetParticleAnisotropies(IntPtr solver, IntPtr anisotropies);

	[PreserveSig]
	public static extern int GetDeformableTriangleCount(IntPtr solver);

	[PreserveSig]
	public static extern void SetDeformableTriangles(IntPtr solver, int[] indices, int num, int destOffset);

	[PreserveSig]
	public static extern int RemoveDeformableTriangles(IntPtr solver, int num, int sourceOffset);

	[PreserveSig]
	public static extern void SetConstraintGroupParameters(IntPtr solver, int type, ref ConstraintParameters parameters);

	[PreserveSig]
	public static extern void GetConstraintGroupParameters(IntPtr solver, int type, ref ConstraintParameters parameters);

	[PreserveSig]
	public static extern void SetRestPositions(IntPtr solver, IntPtr restPositions);

	[PreserveSig]
	public static extern void SetRestOrientations(IntPtr solver, IntPtr restOrientations);

	[PreserveSig]
	public static extern IntPtr CreateBatch(int type);

	[PreserveSig]
	public static extern void DestroyBatch(IntPtr batch);

	[PreserveSig]
	public static extern IntPtr AddBatch(IntPtr solver, IntPtr batch);

	[PreserveSig]
	public static extern void RemoveBatch(IntPtr solver, IntPtr batch);

	[PreserveSig]
	public static extern bool EnableBatch(IntPtr batch, bool enabled);

	[PreserveSig]
	public static extern int GetBatchConstraintForces(IntPtr batch, float[] forces, int num, int destOffset);

	[PreserveSig]
	public static extern void SetBatchConstraintCount(IntPtr batch, int num);

	[PreserveSig]
	public static extern int GetBatchConstraintCount(IntPtr batch);

	[PreserveSig]
	public static extern void SetDistanceConstraints(IntPtr batch, IntPtr indices, IntPtr restLengths, IntPtr stiffnesses, IntPtr lambdas, int num);

	[PreserveSig]
	public static extern void SetBendingConstraints(IntPtr batch, IntPtr indices, IntPtr restBends, IntPtr bendingStiffnesses, IntPtr lambdas, int num);

	[PreserveSig]
	public static extern void SetSkinConstraints(IntPtr batch, IntPtr indices, IntPtr points, IntPtr normals, IntPtr radiiBackstops, IntPtr stiffnesses, IntPtr lambdas, int num);

	[PreserveSig]
	public static extern void SetAerodynamicConstraints(IntPtr batch, IntPtr particleIndices, IntPtr aerodynamicCoeffs, int num);

	[PreserveSig]
	public static extern void SetVolumeConstraints(IntPtr batch, IntPtr triangleIndices, IntPtr firstTriangle, IntPtr numTriangles, IntPtr restVolumes, IntPtr pressureStiffnesses, IntPtr lambdas, int num);

	[PreserveSig]
	public static extern void SetShapeMatchingConstraints(IntPtr batch, IntPtr shapeIndices, IntPtr firstIndex, IntPtr numIndices, IntPtr explicitGroup, IntPtr materialParameters, IntPtr restComs, IntPtr coms, IntPtr orientations, int num);

	[PreserveSig]
	public static extern void CalculateRestShapeMatching(IntPtr solver, IntPtr batch);

	[PreserveSig]
	public static extern void SetStretchShearConstraints(IntPtr batch, IntPtr particleIndices, IntPtr orientationIndices, IntPtr restLengths, IntPtr restOrientations, IntPtr stiffnesses, IntPtr lambdas, int num);

	[PreserveSig]
	public static extern void SetBendTwistConstraints(IntPtr batch, IntPtr orientationIndices, IntPtr restDarboux, IntPtr stiffnesses, IntPtr lambdas, int num);

	[PreserveSig]
	public static extern void SetTetherConstraints(IntPtr batch, IntPtr indices, IntPtr maxLenghtsScales, IntPtr stiffnesses, IntPtr lambdas, int num);

	[PreserveSig]
	public static extern void SetPinConstraints(IntPtr batch, IntPtr indices, IntPtr pinOffsets, IntPtr restDarboux, IntPtr colliders, IntPtr stiffnesses, IntPtr lambdas, int num);

	[PreserveSig]
	public static extern void SetStitchConstraints(IntPtr batch, IntPtr indices, IntPtr stiffnesses, IntPtr lambdas, int num);

	[PreserveSig]
	public static extern void SetChainConstraints(IntPtr batch, IntPtr indices, IntPtr lengths, IntPtr firstIndex, IntPtr numIndex, int num);

	[PreserveSig]
	public static extern void GetCollisionContacts(IntPtr solver, Contact[] contacts, int n);

	[PreserveSig]
	public static extern void GetParticleCollisionContacts(IntPtr solver, Contact[] contacts, int n);

	[PreserveSig]
	public static extern int InterpolateDiffuseParticles(IntPtr solver, IntPtr properties, IntPtr diffusePositions, IntPtr diffuseProperties, IntPtr neighbourCount, int n);

	[PreserveSig]
	public static extern int MakePhase(int group, ParticleFlags flags);

	[PreserveSig]
	public static extern int GetGroupFromPhase(int phase);

	[PreserveSig]
	public static extern int GetFlagsFromPhase(int phase);

	[PreserveSig]
	public static extern float BendingConstraintRest(float[] constraintCoordinates);

	[PreserveSig]
	public static extern void CompleteAll();

	[PreserveSig]
	public static extern void Complete(IntPtr task);

	[PreserveSig]
	public static extern IntPtr CreateEmpty();

	[PreserveSig]
	public static extern void Schedule(IntPtr task);

	[PreserveSig]
	public static extern void AddChild(IntPtr task, IntPtr child);

	[PreserveSig]
	public static extern int GetMaxSystemConcurrency();

	[PreserveSig]
	public static extern void ClearProfiler();

	[PreserveSig]
	public static extern void EnableProfiler(bool cooked);

	[PreserveSig]
	public static extern void BeginSample(string name, byte type);

	[PreserveSig]
	public static extern void EndSample();

	[PreserveSig]
	public static extern int GetProfilingInfoCount();

	[PreserveSig]
	public static extern void GetProfilingInfo([Out] ProfileInfo[] info, int num);
}
