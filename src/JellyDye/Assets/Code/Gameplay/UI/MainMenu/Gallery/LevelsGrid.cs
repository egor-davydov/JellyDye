using Code.Services.Factories;
using UnityEngine;
using UnityEngine.SceneManagement;
using Zenject;

namespace Code.Gameplay.UI.MainMenu.Gallery
{
  public class LevelsGrid : MonoBehaviour
  {
    private LevelButtonFactory _levelButtonFactory;

    [Inject]
    public void Construct(LevelButtonFactory levelButtonFactory)
    {
      _levelButtonFactory = levelButtonFactory;
    }
    
    private void Awake()
    {
      for (int i = 1; i < SceneManager.sceneCountInBuildSettings; i++)
      {
        _levelButtonFactory.CreateLevelButton(transform).GetComponent<LevelButton>().Initialize(i);
      }
    }
  }
}