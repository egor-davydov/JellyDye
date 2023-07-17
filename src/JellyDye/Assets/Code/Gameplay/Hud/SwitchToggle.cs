using UnityEngine;
using UnityEngine.UI;

namespace Code.Gameplay.Hud
{
  public class SwitchToggle : MonoBehaviour
  {
    [SerializeField] private RectTransform _handleRectTransform;
    [SerializeField] private Toggle _toggle;
    [SerializeField] private Image _backgroundImage;
    [SerializeField] private Sprite _onSprite;
    
    private Sprite _offSprite;
    private Vector2 _handlePosition;

    private void Awake()
    {
      _handlePosition = _handleRectTransform.anchoredPosition;
      _offSprite = _backgroundImage.sprite;
      _toggle.onValueChanged.AddListener(OnSwitch);
      if(_toggle.isOn)
        OnSwitch(on: true);
    }

    private void OnSwitch(bool on)
    {
      MoveHandle(on);
      ChangeBackgroundImage(on);
    }

    private void ChangeBackgroundImage(bool on)
    {
      _backgroundImage.sprite = on
        ? _onSprite
        : _offSprite;
    }

    private void MoveHandle(bool on)
    {
      _handleRectTransform.anchoredPosition = on
        ? _handlePosition * -1
        : _handlePosition;
    }
  }
}