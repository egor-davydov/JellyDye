using System;
using UnityEngine;

namespace Code.Gameplay.Jelly
{
  public class JellyMesh : MonoBehaviour
  {
    [SerializeField] private float _intensity = 1f;
    [SerializeField] private float _mass = 1f;
    [SerializeField] private float _stiffness = 1f;
    [SerializeField] private float _damping = 0.75f;
    
    private Mesh _originalMesh;
    private Mesh _meshClone;
    private MeshRenderer _meshRenderer;
    private JellyVertex[] _jellyVertices;
    private Vector3[] _originalMeshVertices;

    private void Start()
    {
      _originalMesh = GetComponent<MeshFilter>().sharedMesh;
      _meshClone = Instantiate(_originalMesh);
      GetComponent<MeshFilter>().sharedMesh = _meshClone;
      _meshRenderer = GetComponent<MeshRenderer>();
      _jellyVertices = new JellyVertex[_meshClone.vertices.Length];
      for (int i = 0; i < _meshClone.vertices.Length; i++) 
        _jellyVertices[i] = new JellyVertex(i, transform.TransformPoint(_meshClone.vertices[i]));
    }

    private void FixedUpdate() 
    {
      _originalMeshVertices = _originalMesh.vertices;
      foreach (JellyVertex jellyVertex in _jellyVertices)
      {
        Vector3 vertex = _originalMeshVertices[jellyVertex.Id];
        Vector3 targetPoint = transform.TransformPoint(vertex);
        float intensity = (1 - (_meshRenderer.bounds.max.y - targetPoint.y) / _meshRenderer.bounds.size.y) * _intensity;
        jellyVertex.Shake(targetPoint, _mass, _stiffness, _damping);
        targetPoint = transform.InverseTransformPoint(jellyVertex.Position);
        _originalMeshVertices[jellyVertex.Id] = Vector3.Lerp(vertex, targetPoint, intensity);
      }

      _meshClone.vertices = _originalMeshVertices;
    }
  }
}