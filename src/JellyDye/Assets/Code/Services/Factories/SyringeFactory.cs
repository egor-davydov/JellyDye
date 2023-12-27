using System.Linq;
using Code.Gameplay.UI.MainMenu.Skins;
using UnityEngine;
using Zenject;

namespace Code.Services.Factories
{
  public class SyringeFactory
  {
    private readonly IInstantiator _instantiator;
    private readonly StaticDataService _staticDataService;
    private readonly ParentsProvider _parentsProvider;

    public SyringeFactory(IInstantiator instantiator, StaticDataService staticDataService, ParentsProvider parentsProvider)
    {
      _instantiator = instantiator;
      _staticDataService = staticDataService;
      _parentsProvider = parentsProvider;
    }

    public GameObject CreateSyringe(SkinType skinType, Vector3 at)
    {
      GameObject syringePrefab = _staticDataService.ForSkins().SkinConfigs.First(config => config.SkinType == skinType).SkinPrefab;
      GameObject syringeObject = _instantiator.InstantiatePrefab(syringePrefab, at, syringePrefab.transform.rotation, _parentsProvider.ParentForGameplay);
      
      return syringeObject;
    }
  }
}