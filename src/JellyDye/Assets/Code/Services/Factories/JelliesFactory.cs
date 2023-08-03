using UnityEngine;
using Zenject;

namespace Code.Services.Factories
{
  public class JelliesFactory
  {
    private readonly IInstantiator _instantiator;

    public JelliesFactory(IInstantiator instantiator)
    {
      _instantiator = instantiator;
    }

    public GameObject CreateJelly(GameObject jellyPrefab)
    {
      GameObject jelliesObject = _instantiator.InstantiatePrefab(jellyPrefab, new GameObject("JelliesParent").transform);
      return jelliesObject;
    }
  }
}