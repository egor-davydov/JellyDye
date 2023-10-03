using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Code.Gameplay.UI
{
  public class GreenButton : MonoBehaviour
  {
    [SerializeField] private float _moveTime;
    [SerializeField] private UIAudio _uiAudio;
    [SerializeField] private Button _button;

    private Tween _tween;

    private void Awake()
    {
      _tween = ((RectTransform)transform).DOAnchorPos(Vector2.zero, _moveTime);
      _button.onClick.AddListener(OnGreenButtonClick);
    }

    private void OnGreenButtonClick() => 
      _uiAudio.PlayClick();

    private void OnDestroy() =>
      _tween.Kill();
  }
}