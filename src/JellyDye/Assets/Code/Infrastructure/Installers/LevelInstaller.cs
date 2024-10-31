using Code.Gameplay.Logic;
using Code.Services;
using Code.Services.Providers;
using UnityEngine;
using Zenject;

namespace Code.Infrastructure.Installers
{
  public class LevelInstaller : MonoInstaller
  {
    [SerializeField] private LevelCamera _levelCamera;
    [SerializeField] private MeshFilter _meshFilter;
    [Header("Parents")] [SerializeField] private Transform _otherParent;
    [SerializeField] private Transform _gameplayParent;
    [SerializeField] private Transform _uiParent;

    private CameraService _cameraService;
    private ScreenshotService _screenshotService;
    private ParentsProvider _parentsProvider;

    [Inject]
    public void Construct(CameraService cameraService, ScreenshotService screenshotService,
      ParentsProvider parentsProvider)
    {
      _parentsProvider = parentsProvider;
      _screenshotService = screenshotService;
      _cameraService = cameraService;
    }

    public void Awake()
    {
      _screenshotService.Initialize(_meshFilter.sharedMesh, _levelCamera.Camera);
      _cameraService.Initialize(_levelCamera);
      _parentsProvider.Initialize(_otherParent, _gameplayParent, _uiParent);
    }

    public override void InstallBindings()
    {
    }
  }
}