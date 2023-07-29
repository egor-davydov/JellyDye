using Fluxy;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

namespace Code.Gameplay
{
  [ExecuteInEditMode]
  public class JellyAutoConstruct : MonoBehaviour
  {
    public GameObject softbodyBasePrefab;
    public Mesh mesh;

    public void Construct()
    {
    }
  }
}