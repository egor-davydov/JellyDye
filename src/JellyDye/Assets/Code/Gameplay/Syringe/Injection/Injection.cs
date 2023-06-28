using System;
using UnityEngine;

namespace Code.Gameplay.Syringe.Injection
{
  public class Injection : MonoBehaviour
  {
    public MeshFilter MeshFilter;

    private void Start()
    {
      foreach (Color sharedMeshColor in MeshFilter.sharedMesh.colors) 
        Debug.Log(sharedMeshColor);
    }
  }
}