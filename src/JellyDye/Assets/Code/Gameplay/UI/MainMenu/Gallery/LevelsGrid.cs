using Code.Services;
using Code.Services.Factories;
using Code.Services.Factories.UI;
using Code.StaticData;
using UnityEngine;
using Zenject;

namespace Code.Gameplay.UI.MainMenu.Gallery
{
  public class LevelsGrid : MonoBehaviour
  {
    private LevelButtonFactory _levelButtonFactory;
    private StaticDataService _staticDataService;

    [Inject]
    public void Construct(LevelButtonFactory levelButtonFactory, StaticDataService staticDataService)
    {
      _staticDataService = staticDataService;
      _levelButtonFactory = levelButtonFactory;
    }
    
    private void Awake()
    {
      LevelConfig[] levelConfigs = _staticDataService.ForLevels().LevelConfigs;
      for (int i = 0; i < levelConfigs.Length; i++)
      {
        _levelButtonFactory.CreateLevelButton(transform).GetComponent<LevelButton>().Initialize(i);
      }
    }
  }
}