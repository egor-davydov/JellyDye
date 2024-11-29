using DG.Tweening;
using UnityEngine;

namespace Code.Gameplay.UI
{
  public class AnimatedButton : MonoBehaviour
  {
    [SerializeField] private float _moveTime;

    private Tween _tween;
    private RectTransform _rectTransform;

    private void Awake() =>
      _rectTransform = ((RectTransform)transform);

    public void Animate() =>
      _tween = _rectTransform.DOAnchorPos(Vector2.zero, _moveTime).SetEase(Ease.OutQuad).Play();

    public void SetFinishPosition() =>
      _rectTransform.anchoredPosition = Vector2.zero;

    private void OnDestroy() =>
      _tween.Kill();
  }
}