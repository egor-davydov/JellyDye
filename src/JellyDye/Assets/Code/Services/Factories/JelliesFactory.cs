using UnityEngine;
using Zenject;

namespace Code.Services.Factories
{
  public class JelliesFactory
  {
    private readonly IInstantiator _instantiator;
    private readonly ParentsProvider _parentsProvider;
    private readonly StaticDataService _staticDataService;

    public JelliesFactory(IInstantiator instantiator, ParentsProvider parentsProvider, StaticDataService staticDataService)
    {
      _instantiator = instantiator;
      _parentsProvider = parentsProvider;
      _staticDataService = staticDataService;
    }

    public GameObject CreateJelly(string id)
    {
      GameObject jelliesPrefab = _staticDataService.ForLevels().GetConfigByLevelId(id).JelliesPrefab;
      GameObject jelliesObject = _instantiator.InstantiatePrefab(jelliesPrefab, _parentsProvider.ParentForGameplay);
      return jelliesObject;
    }
  }
}