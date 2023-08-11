using DG.Tweening;
using UnityEngine;

namespace Code.Gameplay.Hud
{
  public class GreenButton : MonoBehaviour
  {
    [SerializeField] private float _moveTime;
    
    private Tween _tween;

    private void Awake()
    {
      _tween = ((RectTransform)transform).DOAnchorPos(Vector2.zero, _moveTime);
    }

    private void OnDestroy()
    {
      _tween.Kill();
    }
  }
}