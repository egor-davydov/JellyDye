using Code.Gameplay.Logic;
using Code.Services;
using Code.Services.Providers;
using UnityEngine;
using Zenject;

namespace Code.Infrastructure.Installers
{
  public class LevelInstaller : MonoInstaller, IInitializable
  {
    [SerializeField] private LevelCamera _levelCamera;
    [SerializeField] private MeshFilter _meshFilter;
    [Header("Parents")]
    [SerializeField] private Transform _otherParent;
    [SerializeField] private Transform _gameplayParent;
    [SerializeField] private Transform _uiParent;
    
    private CameraService _cameraService;
    private ScreenshotService _screenshotService;
    private ParentsProvider _parentsProvider;

    public override void InstallBindings()
    {
      Container.BindInterfacesAndSelfTo<LevelInstaller>().FromInstance(this).AsSingle();
    }

    [Inject]
    public void Construct(CameraService cameraService, ScreenshotService screenshotService, ParentsProvider parentsProvider)
    {
      _parentsProvider = parentsProvider;
      _screenshotService = screenshotService;
      _cameraService = cameraService;
    }

    public void Initialize()
    {
      _screenshotService.Initialize(_meshFilter.sharedMesh, _levelCamera.Camera);
      _cameraService.Initialize(_levelCamera);
      _parentsProvider.Initialize(_otherParent, _gameplayParent, _uiParent);
    }
  }
}