using System.Linq;
using Code.Services;
using Code.Services.Progress;
using Code.StaticData;
using Fluxy;
using UnityEngine;
using Zenject;

namespace Code.Helpers
{
  public class SetTargetColorFromClearColor : MonoBehaviour
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
      JellyMeshConfig jellyMeshConfig = _staticDataService.ForLevels().GetJellyConfigByMesh(fluxyContainer.customMesh);
      GetComponentInChildren<FluxyTarget>().color = jellyMeshConfig.TargetColor;
    }
#endif
  }
}