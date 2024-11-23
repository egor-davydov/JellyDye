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
    private StaticDataService _staticDataService;

    [Inject]
    public void Construct(StaticDataService staticDataService)
    {
      _staticDataService = staticDataService;
    }

    private void Awake()
    {
      FluxyContainer fluxyContainer = GetComponent<FluxyContainer>();
      JellyMeshConfig jellyMeshConfig = _staticDataService.Levels.GetJellyConfigByMesh(fluxyContainer.customMesh);
      FluxyTarget fluxyTarget = GetComponentInChildren<FluxyTarget>();
      fluxyTarget.color = jellyMeshConfig.TargetColor;
    }
#endif
  }
}