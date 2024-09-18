using Code.Gameplay.Logic.UI;
using Code.Services.Providers;
using UnityEngine;
using Zenject;

namespace Code.Infrastructure.Installers
{
  public class LevelLoadInstaller : MonoInstaller
  {
    [SerializeField] private LevelLoadingFill _levelLoadingFill;
    
    private LevelLoadingFillProvider _levelLoadingFillProvider;

    [Inject]
    public void Construct(LevelLoadingFillProvider levelLoadingFillProvider)
    {
      _levelLoadingFillProvider = levelLoadingFillProvider;
    }

    private void Awake()
    {
      _levelLoadingFillProvider.Initialize(_levelLoadingFill);
    }

    public override void InstallBindings()
    {
    }
  }
}