using Obi;
using UnityEngine;

namespace Code.Gameplay.Logic
{
  public class FixObiParticles : MonoBehaviour
  {
    [SerializeField] private ObiActor _obiActor;
    [SerializeField] private Transform _anchorTransform;
    [SerializeField] private float _anchorRadius;

    private ObiSolver ObiSolver => _obiActor.solver;

    private void Start()
    {
      foreach (int solverIndex in _obiActor.solverIndices)
      {
        float particleDistanceToAnchor = Vector3.Distance(_obiActor.GetParticlePosition(solverIndex), _anchorTransform.position);
        if (particleDistanceToAnchor > _anchorRadius)
          continue;
        
        ObiSolver.velocities[solverIndex] = Vector3.zero;
        ObiSolver.invMasses[solverIndex] = 0;
      }
    }

#if UNITY_EDITOR
    private void OnDrawGizmos()
    {
      Gizmos.color = Color.red;
      Gizmos.DrawWireSphere(_anchorTransform.position, _anchorRadius);
    }
#endif
  }
}