using Code.Gameplay.Logic;
using Code.Services;
using UnityEngine;
using Zenject;

namespace Code.Infrastructure.Installers
{
  public class LevelInstaller : MonoInstaller, IInitializable
  {
    [SerializeField] private LevelCamera _levelCamera;
    [SerializeField] private MeshFilter _meshFilter;
    
    private CameraService _cameraService;
    private ScreenshotService _screenshotService;

    public override void InstallBindings()
    {
      Container.BindInterfacesAndSelfTo<LevelInstaller>().FromInstance(this).AsSingle();
    }

    [Inject]
    public void Construct(CameraService cameraService, ScreenshotService screenshotService)
    {
      _screenshotService = screenshotService;
      _cameraService = cameraService;
    }

    public void Initialize()
    {
      _screenshotService.Initialize(_meshFilter.sharedMesh, _levelCamera.Camera);
      _cameraService.Initialize(_levelCamera);
    }
  }
}