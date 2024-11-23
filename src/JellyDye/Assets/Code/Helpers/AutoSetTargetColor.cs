using Code.Services;
using Code.StaticData;
using Fluxy;
using UnityEngine;
using Zenject;

namespace Code.Helpers
{
  public class AutoSetTargetColor : MonoBehaviour
  {
#if UNITY_EDITOR
    private StaticDataService _staticData;

    [Inject]
    public void Construct(StaticDataService staticDataService)
    {
      _staticData = staticDataService;
    }

    private void Awake()
    {
      FluxyContainer fluxyContainer = GetComponent<FluxyContainer>();
      JellyMeshConfig jellyMeshConfig = _staticData.ForLevels.GetJellyConfigByMesh(fluxyContainer.customMesh);
      FluxyTarget fluxyTarget = GetComponentInChildren<FluxyTarget>();
      fluxyTarget.color = jellyMeshConfig.TargetColor;
    }
#endif
  }
}