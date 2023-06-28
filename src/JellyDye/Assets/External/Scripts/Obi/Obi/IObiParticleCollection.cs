using UnityEngine;

namespace Obi
{
	public interface IObiParticleCollection
	{
		int particleCount { get; }

		int activeParticleCount { get; }

		bool usesOrientedParticles { get; }

		int GetParticleRuntimeIndex(int index);

		Vector3 GetParticlePosition(int index);

		Quaternion GetParticleOrientation(int index);

		void GetParticleAnisotropy(int index, ref Vector4 b1, ref Vector4 b2, ref Vector4 b3);

		float GetParticleMaxRadius(int index);

		Color GetParticleColor(int index);
	}
}
