using Obi;
using UnityEngine;

namespace Code.Gameplay.Logic
{
  public class FixObiParticles : MonoBehaviour
  {
    [SerializeField] private ObiActor[] _obiActors;
    [SerializeField] private BoxCollider _fixingBox;

    private void Start()
    {
      foreach (ObiActor obiActor in _obiActors)
      {
        foreach (int solverIndex in obiActor.solverIndices)
        {
          Vector3 particlePosition = obiActor.GetParticlePosition(solverIndex);
          if (!_fixingBox.bounds.Contains(particlePosition))
            continue;
        
          obiActor.solver.velocities[solverIndex] = Vector3.zero;
          obiActor.solver.invMasses[solverIndex] = 0;
        }
      }
    }
  }
}