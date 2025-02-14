using Code.Gameplay.Logic;
using Code.Services;
using Code.Services.Providers;
using UnityEngine;
using UnityEngine.EventSystems;
using Zenject;

namespace Code.Infrastructure.Installers
{
  public class LevelInstaller : MonoInstaller
  {
    [SerializeField] private LevelCamera _levelCamera;
    [SerializeField] private MeshFilter _jelliesPlatformMesh;
    [SerializeField] private Light _directionalLight;
    [SerializeField] private EventSystem _eventSystem;
    [Header("Parents")] [SerializeField] private Transform _otherParent;
    [SerializeField] private Transform _gameplayParent;
    [SerializeField] private Transform _uiParent;

    private CameraProvider _cameraProvider;
    private ScreenshotService _screenshotService;
    private ParentsProvider _parentsProvider;
    private AdditiveSceneInterferingObjectsProvider _additiveSceneInterferingObjectsProvider;

    [Inject]
    public void Construct(CameraProvider cameraProvider, ScreenshotService screenshotService,
      ParentsProvider parentsProvider, AdditiveSceneInterferingObjectsProvider additiveSceneInterferingObjectsProvider)
    {
      _additiveSceneInterferingObjectsProvider = additiveSceneInterferingObjectsProvider;
      _parentsProvider = parentsProvider;
      _screenshotService = screenshotService;
      _cameraProvider = cameraProvider;
    }

    public void Awake()
    {
      _screenshotService.Initialize(_jelliesPlatformMesh.sharedMesh, _levelCamera.Camera);
      _cameraProvider.LevelCamera = _levelCamera;
      _parentsProvider.Initialize(_otherParent, _gameplayParent, _uiParent);
      _additiveSceneInterferingObjectsProvider.InterferingObjects = new[]
      {
        _directionalLight.gameObject,
        _eventSystem.gameObject,
        _uiParent.gameObject,
        _levelCamera.gameObject
      };
    }

    public override void InstallBindings()
    {
    }
  }
}