using Code.Gameplay.Logic;
using Code.Services;
using UnityEngine;
using Zenject;

namespace Code.Infrastructure.Installers
{
  public class LevelInstaller : MonoInstaller, IInitializable
  {
    [SerializeField] private LevelCamera _levelCamera;
    
    private CameraService _cameraService;
    public override void InstallBindings()
    {
      Container.BindInterfacesAndSelfTo<LevelInstaller>().FromInstance(this).AsSingle();
    }

    [Inject]
    public void Construct(CameraService cameraService)
    {
      _cameraService = cameraService;
    }

    public void Initialize()
    {
      _cameraService.Initialize(_levelCamera);
    }
  }
}