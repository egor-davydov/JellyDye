using Code.Services;
using UnityEngine;
using Zenject;

namespace Code.Infrastructure.Installers
{
  public class NewSkinSceneInstaller : MonoInstaller
  {
    [SerializeField] private Transform _newSkinStandTransform;
    [SerializeField] private Transform _skinRotationPointTransform;

    private NewSkinSceneService _newSkinSceneService;

    [Inject]
    public void Construct(NewSkinSceneService newSkinSceneService)
    {
      _newSkinSceneService = newSkinSceneService;
    }

    private void Awake()
    {
      _newSkinSceneService.Initialize(_newSkinStandTransform, _skinRotationPointTransform.position);
    }

    public override void InstallBindings()
    {
    }
  }
}