using Code.Services;
using Code.UI.SkinShow;
using UnityEngine;
using Zenject;

namespace Code.Infrastructure.Installers
{
  public class NewSkinSceneInstaller : MonoInstaller
  {
    [SerializeField] private Transform _newSkinStandTransform;
    [SerializeField] private Transform _skinRotationPointTransform;
    [SerializeField] private SkinShowHud _skinShowHud;
    [SerializeField] private AudioSource _audioSource;

    private SkinShowSceneService _skinShowSceneService;

    [Inject]
    public void Construct(SkinShowSceneService skinShowSceneService)
    {
      _skinShowSceneService = skinShowSceneService;
    }

    private void Awake()
    {
      _skinShowSceneService.Initialize(_newSkinStandTransform, _skinRotationPointTransform.position, _skinShowHud, _audioSource);
    }

    public override void InstallBindings()
    {
    }
  }
}