using UnityEngine;

namespace Obi
{
	public interface ISolverImpl
	{
		void Destroy();

		void InitializeFrame(Vector4 translation, Vector4 scale, Quaternion rotation);

		void UpdateFrame(Vector4 translation, Vector4 scale, Quaternion rotation, float deltaTime);

		void ApplyFrame(float worldLinearInertiaScale, float worldAngularInertiaScale, float deltaTime);

		void ParticleCountChanged(ObiSolver solver);

		void ParticleCapacityChanged(ObiSolver solver);

		void SetActiveParticles(int[] indices, int num);

		void InterpolateDiffuseProperties(ObiNativeVector4List properties, ObiNativeVector4List diffusePositions, ObiNativeVector4List diffuseProperties, ObiNativeIntList neighbourCount, int diffuseCount);

		void SetRigidbodyArrays(ObiSolver solver);

		IConstraintsBatchImpl CreateConstraintsBatch(Oni.ConstraintType type);

		void DestroyConstraintsBatch(IConstraintsBatchImpl batch);

		int GetConstraintCount(Oni.ConstraintType type);

		void GetCollisionContacts(Oni.Contact[] contacts, int count);

		void GetParticleCollisionContacts(Oni.Contact[] contacts, int count);

		void SetConstraintGroupParameters(Oni.ConstraintType type, ref Oni.ConstraintParameters parameters);

		IObiJobHandle CollisionDetection(float stepTime);

		IObiJobHandle Substep(float substepTime);

		void ApplyInterpolation(ObiNativeVector4List startPositions, ObiNativeQuaternionList startOrientations, float stepTime, float unsimulatedTime);

		int GetDeformableTriangleCount();

		void SetDeformableTriangles(int[] indices, int num, int destOffset);

		int RemoveDeformableTriangles(int num, int sourceOffset);

		void SetParameters(Oni.SolverParameters parameters);

		void GetBounds(ref Vector3 min, ref Vector3 max);

		void ResetForces();

		int GetParticleGridSize();

		void GetParticleGrid(ObiNativeAabbList cells);
	}
}
