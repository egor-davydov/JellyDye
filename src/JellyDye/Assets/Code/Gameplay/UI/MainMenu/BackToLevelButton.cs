using UnityEngine;
using UnityEngine.UI;

namespace Code.Gameplay.UI.MainMenu
{
  public class BackToLevelButton : MonoBehaviour
  {
    [SerializeField] private GameObject _menuObject;
    [SerializeField] private Button _backButton;

    private void Awake() =>
      _backButton.onClick.AddListener(CloseMenu);

    private void CloseMenu() =>
      Destroy(_menuObject);
  }
}