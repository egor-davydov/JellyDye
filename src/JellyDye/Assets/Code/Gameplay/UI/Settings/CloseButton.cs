using UnityEngine;
using UnityEngine.UI;

namespace Code.Gameplay.UI.Settings
{
  public class CloseButton : MonoBehaviour
  {
    [SerializeField] private Button _closeButton;
    [SerializeField] private GameObject _objectToClose;

    private void Awake() => 
      _closeButton.onClick.AddListener(() => Destroy(_objectToClose));
  }
}