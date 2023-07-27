using System.Collections.Generic;
using Obi;
using UnityEngine;

namespace Code.Gameplay.Logic
{
  public class FixObiParticles : MonoBehaviour
  {
    [SerializeField] private List<ObiActor> _obiActors;
    [SerializeField] private Transform _anchorTransform;
    [SerializeField] private float _anchorRadius;

    private void Start()
    {
      foreach (ObiActor obiActor in _obiActors)
      {
        foreach (int solverIndex in obiActor.solverIndices)
        {
          float particleDistanceToAnchor = Vector3.Distance(obiActor.GetParticlePosition(solverIndex), _anchorTransform.position);
          if (particleDistanceToAnchor > _anchorRadius)
            continue;
        
          obiActor.solver.velocities[solverIndex] = Vector3.zero;
          obiActor.solver.invMasses[solverIndex] = 0;
        }
      }
    }

#if UNITY_EDITOR
    private void OnDrawGizmosSelected()
    {
      Gizmos.color = Color.red;
      Gizmos.DrawSphere(_anchorTransform.position, _anchorRadius);
    }
#endif
  }
}