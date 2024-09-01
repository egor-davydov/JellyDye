using Code.Services;
using Code.Services.AssetManagement;

namespace Code.Infrastructure.States
{
  public class InitializationState : IState
  {
    private const string LoadSceneName = "Load";
    
    private readonly GameStateMachine _gameStateMachine;
    private readonly StaticDataService _staticDataService;
    private readonly PublishService _publishService;
    private readonly SceneLoader _sceneLoader;
    private readonly IAssetProvider _assetProvider;

    public InitializationState(GameStateMachine gameStateMachine, StaticDataService staticDataService,
      PublishService publishService, SceneLoader sceneLoader, IAssetProvider assetProvider)
    {
      _gameStateMachine = gameStateMachine;
      _staticDataService = staticDataService;
      _publishService = publishService;
      _sceneLoader = sceneLoader;
      _assetProvider = assetProvider;
    }

    public void Enter()
    {
      _staticDataService.LoadData();
      _assetProvider.Initialize();
      // WebDebug.Log($"IsOnCrazyGames={CrazySDK.IsOnCrazyGames}");
      // WebDebug.Log($"Application.absoluteURL={Application.absoluteURL}");
      if (_publishService.IsOnYandexGames())
        _publishService.InitializeYandex(OnSdkInitialize, OnPlayerInitialized);
      else
        OnPlayerInitialized();
    }

    public void Exit()
    {
    }

    private void OnPlayerInitialized()
    {
      MoveToNextState();
    }

    private void OnSdkInitialize() => 
      _sceneLoader.StartLoad(LoadSceneName);

    private void MoveToNextState() =>
      _gameStateMachine.Enter<LoadProgressState>();

  }
}