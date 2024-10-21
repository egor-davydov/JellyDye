using Code.Gameplay.UI.NewSkin;
using Code.Services;
using UnityEngine;
using Zenject;

namespace Code.Infrastructure.Installers
{
  public class NewSkinSceneInstaller : MonoInstaller
  {
    [SerializeField] private Transform _newSkinStandTransform;
    [SerializeField] private Transform _skinRotationPointTransform;
    [SerializeField] private NewSkinHud _newSkinHud;
    [SerializeField] private AudioSource _audioSource;

    private NewSkinSceneService _newSkinSceneService;

    [Inject]
    public void Construct(NewSkinSceneService newSkinSceneService)
    {
      _newSkinSceneService = newSkinSceneService;
    }

    private void Awake()
    {
      _newSkinSceneService.Initialize(_newSkinStandTransform, _skinRotationPointTransform.position, _newSkinHud, _audioSource);
    }

    public override void InstallBindings()
    {
    }
  }
}