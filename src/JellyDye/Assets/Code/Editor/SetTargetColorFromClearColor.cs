using System.Linq;
using Code.Services;
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
      JellyConfig jellyConfig = _staticDataService.ForJellies().JellyConfigs.First(config => config.Mesh == fluxyContainer.customMesh);
      GetComponentInChildren<FluxyTarget>().color = jellyConfig.TargetColor;
    }
#endif
  }
}