using UnityEngine;
using Zenject;

namespace Code.Services.Factories
{
  public class JelliesFactory
  {
    private readonly IInstantiator _instantiator;
    private readonly ParentsProvider _parentsProvider;

    public JelliesFactory(IInstantiator instantiator, ParentsProvider parentsProvider)
    {
      _instantiator = instantiator;
      _parentsProvider = parentsProvider;
    }

    public GameObject CreateJelly(GameObject jellyPrefab)
    {
      GameObject jelliesObject = _instantiator.InstantiatePrefab(jellyPrefab, _parentsProvider.ParentForGameplay);
      return jelliesObject;
    }
  }
}