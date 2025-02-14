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
    private JellyMeshConfig _jellyMeshConfig;
    private FluxyTarget _fluxyTarget;

    [Inject]
    public void Construct(StaticDataService staticDataService)
    {
      _staticData = staticDataService;
    }

    private void Awake()
    {
      FluxyContainer fluxyContainer = GetComponent<FluxyContainer>();
      _jellyMeshConfig = _staticData.ForLevels.GetJellyConfigByMesh(fluxyContainer.customMesh);
      _fluxyTarget = GetComponentInChildren<FluxyTarget>();
    }

    private void Update()
    {
      _fluxyTarget.color = _jellyMeshConfig.TargetColor;
    }
#endif
  }
}