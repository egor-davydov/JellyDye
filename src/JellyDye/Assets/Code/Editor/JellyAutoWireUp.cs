using System.Collections;
using Code.Gameplay.Logic;
using Fluxy;
using Obi;
using UnityEngine;

namespace Code.Editor
{
  public class JellyAutoWireUp
  {
    public static GameObject WireUpJelly(GameObject newSoftbodyObject, Mesh withMesh, GameObject jellyBase, ObiSoftbodySurfaceBlueprint meshBlueprint)
    {
      WireUpObi(withMesh, newSoftbodyObject, jellyBase, meshBlueprint);
      WireUpFluxy(withMesh, newSoftbodyObject, jellyBase);
      WireUpMeshCollider(withMesh, newSoftbodyObject);
      return newSoftbodyObject;
    }

    private static void WireUpObi(Mesh withMesh, GameObject newSoftbodyObject, GameObject jellyBase, ObiSoftbodySurfaceBlueprint blueprint)
    {
      ObiSoftbody obiSoftbody = newSoftbodyObject.GetComponentInChildren<ObiSoftbody>();
      jellyBase.GetComponentInChildren<FixObiParticles>()._obiActors.Add(obiSoftbody);
      jellyBase.GetComponentInChildren<ObiFixedUpdater>().solvers.Add(obiSoftbody.solver);
      
      obiSoftbody.gameObject.name = withMesh.name;
      obiSoftbody.softbodyBlueprint = blueprint;
      ObiSoftbodySkinner skinner = obiSoftbody.GetComponent<ObiSoftbodySkinner>();
      skinner.m_Target.sharedMesh = withMesh;
      IEnumerator bindSkinEnumerator = skinner.BindSkin();
      while (bindSkinEnumerator.MoveNext()) {}
    }

    private static void WireUpFluxy(Mesh withMesh, GameObject newSoftbodyObject, GameObject jellyBase)
    {
      FluxyContainer fluxyContainer = newSoftbodyObject.GetComponentInChildren<FluxyContainer>();
      fluxyContainer.customMesh = withMesh;
      fluxyContainer.skinnedMeshRenderer.sharedMesh = withMesh;
      fluxyContainer.solver = jellyBase.GetComponentInChildren<FluxySolver>();
      fluxyContainer.transform.localPosition = fluxyContainer.customMesh.bounds.center;
      //Debug.Log($"name= {customMesh.name}; wasPosition= {fluxyContainer.transform.localPosition}; containerCenter= {meshCenter};");
    }

    private static void WireUpMeshCollider(Mesh withMesh, GameObject newSoftbodyObject) => 
      newSoftbodyObject.GetComponentInChildren<MeshCollider>().sharedMesh = withMesh;
  }
}